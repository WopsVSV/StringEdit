using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace StringEdit
{
    public class Extractor
    {
        private string path;
        private readonly string extractorPath;

        public List<string> ExtractedStrings = new List<string>();

        /// <summary>
        /// Initialises values and starts the process
        /// </summary>
        /// <param name="path"></param>
        public Extractor(string path)
        {
            this.path = path;

            extractorPath = Path.GetFullPath(Extensions.InternalCheckIsWow64() ? "strings64.exe" : "strings32.exe");

            AcceptEula();

        }

        /// <summary>
        /// Extracts raw strings
        /// </summary>
        public void Extract(string additionalParameters)
        {
            // Executes the extraction process
            var extractionProcess = GetExtractionProcess($"-nobanner {additionalParameters} {path}");
            extractionProcess.Start();

            // Extracts
            var line = string.Empty;
            while (!extractionProcess.StandardOutput.EndOfStream)
            {
                line = extractionProcess.StandardOutput.ReadLine();

                if (Globals.UseExtremeFilters && ExtremeFilters.Parse(line) == null) continue;
                if (Globals.UseSmartFilters && SmartFilters.Parse(line) == null) continue;
                
                ExtractedStrings.Add(line);                
            }

            if(Globals.RemoveDuplicates)
                 ExtractedStrings = ExtractedStrings.Distinct().ToList();
        }

        /// <summary>
        /// Accepts the eula of the strings program
        /// </summary>
        private void AcceptEula()
        {
            var eulaProcess = GetExtractionProcess("-accepteula");
            eulaProcess.Start();
            eulaProcess.WaitForExit();
        }

        /// <summary>
        /// Returns an extraction process with specific parameters
        /// </summary>
        private Process GetExtractionProcess(string arguments)
        {
            return new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = extractorPath,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
        }

    }
}
