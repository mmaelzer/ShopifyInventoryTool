using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ShopifyInventoryTool
{
    class DescriptionHelper
    {
        readonly Dictionary<string, DescriptionObject> _descriptions;

        /// <summary>
        /// UNFINISHED: Class for editing descriptions for multiple items at once
        /// </summary>
        public DescriptionHelper()
        {
            _descriptions = new Dictionary<string, DescriptionObject>();
        }

        public void Add(string moniker, string description)
        {
            _descriptions.Add(moniker, new DescriptionObject(moniker, description));

            updateUniqueLines();
        }

        public void Clear()
        {
            _descriptions.Clear();
        }

        public string GetDescription()
        {
            var builder = new StringBuilder();
            if (_descriptions.Count > 0)
            {
                foreach(var line in _descriptions.First().Value.Lines.Where(l => !l.IsUnique))
                {
                    builder.AppendLine(line.Line);
                }
            }
            else
            {
                builder.Append(string.Empty);
            }

            return builder.ToString();
        }

        /// <summary>
        /// UNFINISHED: This would only save the changes made to a batch of descriptions, thus retaining existing information
        /// </summary>
        /// <param name="newDescription"></param>
        public void SaveDescription(string newDescription)
        {
            var lines = new List<DescriptionLine>();
            var counter = 0;

            using (var reader = new StringReader(newDescription))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(new DescriptionLine(line, counter++, false));
                }
            }

            int offset = 0;

            foreach (var description in _descriptions)
            {
                foreach (var descriptionLine in description.Value.Lines)
                {

                }
            }
        }

        private void updateUniqueLines()
        {
            foreach (var description in _descriptions)
            {
                foreach (var descriptionLine in description.Value.Lines)
                {
                    descriptionLine.IsUnique = true;

                    foreach (var desc in from desc in _descriptions.Select(d => d).Where(d => d.Key != description.Key)
                                         from descLine in desc.Value.Lines.Where(descLine => descLine.Line == descriptionLine.Line)
                                         select desc)
                    {
                        descriptionLine.IsUnique = false;
                        continue;
                    }
                }
            }
        }
    }

    internal class DescriptionObject
    {
        public DescriptionObject(string moniker, string description)
        {
            Moniker = moniker;
            Lines = parseDescription(description);
        }

        public string Moniker
        {
            get; set;
        }

        public List<DescriptionLine> Lines
        {
            get; set;
        }

        private static List<DescriptionLine> parseDescription(string description)
        {
            var lines = new List<DescriptionLine>();
            var counter = 0;

            using (var reader = new StringReader(description))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(new DescriptionLine(line, counter++, false));
                }
            }

            return lines;
        }
    }

    internal class DescriptionLine
    {
        public DescriptionLine(string line, int lineNum, bool unique)
        {
            Line = line;
            IsUnique = unique;
            LineNumber = lineNum;
        }

        public bool IsUnique { get; set; }

        public int LineNumber { get; private set; }

        public string Line { get; private set; }
    }
}
