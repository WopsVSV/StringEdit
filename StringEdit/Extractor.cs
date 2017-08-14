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
        private StringExtract.Library.Extractor extractor;

        public List<string> ExtractedStrings = new List<string>();

        /// <summary>
        /// Initialises values and starts the process
        /// </summary>
        /// <param name="path"></param>
        public Extractor(string path)
        {
            this.path = path;

            extractor = new StringExtract.Library.Extractor();
        }

        /// <summary>
        /// Extracts raw strings
        /// </summary>
        public void Extract(int minCharacters)
        {
            // Executes the extraction process
            extractor.MinimumCharacters = minCharacters;

            foreach (var line in extractor.Extract(path))
            {
                if (Globals.UseExtremeFilters && ExtremeFilters.Parse(line) == null) continue;
                if (Globals.UseSmartFilters && SmartFilters.Parse(line) == null) continue;

                ExtractedStrings.Add(line);
            }

            if(Globals.RemoveDuplicates)
                 ExtractedStrings = ExtractedStrings.Distinct().ToList();
        }

    }
}
