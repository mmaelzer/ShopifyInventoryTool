using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShopifyInventoryTool
{
    public class ShopifyData
    {
        #region Constants

        private const string ConfigFile = "shopifytool.cfg";
        private static readonly string[] ValidExtensions = new[] {".jpg",".png", ".bmp", ".gif", ".jpeg"};

        #endregion

        #region Fields

        private static ShopifyData _instance;
        private readonly Dictionary<string, ShopifyProduct> _products = new Dictionary<string, ShopifyProduct>();
        private readonly Dictionary<int, string> _columnHeaders = new Dictionary<int, string>();
        private int _columnCount;

        #endregion

        #region Public Methods

        public ShopifyProduct GetProduct(string handle)
        {
            ShopifyProduct value;
            return _products.TryGetValue(handle, out value) ? value : null;
        }

        public void ImportDataFromImages(string path, ShopifyImportData data)
        {
            importProductData(path, data);
        }

        public void NewData()
        {
            try
            {
                _products.Clear();
                _columnHeaders.Clear();

                using (var reader = new StreamReader(ConfigFile))
                {
                    var line = reader.ReadLine();
                    var columnHeaderStrings = line.Split(',');
                    _columnCount = columnHeaderStrings.Count();

                    for (var i = 0; i < _columnCount; i++)
                    {
                        _columnHeaders.Add(i, columnHeaderStrings[i]);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public bool ReadData(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    return false;
                }

                using (var reader = new StreamReader(path))
                {
                    var line = reader.ReadLine();
                    
                    var columnHeaderStrings = line.Split(',');
                    _columnCount = columnHeaderStrings.Count();
                    _columnHeaders.Clear();
                    for (var i = 0; i < _columnCount; i++)
                    {
                        _columnHeaders.Add(i, columnHeaderStrings[i]);
                    }
                    
                    var newProducts = csvToShopifyData(reader.ReadToEnd());
                    foreach (var product in newProducts)
                    {
                        if (!_products.ContainsKey(product.Key))
                        {
                            _products.Add(product.Key, product.Value);
                        }
                    }
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool SaveData(string path)
        {
            try
            {
                using (var writer = new StreamWriter(path, false, Encoding.UTF8))
                {
                    for (var i = 0; i < _columnHeaders.Keys.Count; i++)
                    {
                        writer.Write(_columnHeaders[i]);
                        if (i + 1 != _columnHeaders.Keys.Count)
                        {
                            writer.Write(",");
                        }
                        else
                        {
                            writer.Write('\n');
                        }
                    }

                    foreach (var product in _products.Values)
                    {
                        writer.Write(product.CsvEntry);
                        writer.Write('\n');
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public void UpdateData(List<ShopifyProduct> products)
        {
            foreach (var product in products)
            {
                if (_products.ContainsKey(product.Handle))
                {
                    _products[product.Handle] = product;
                }
                else
                {
                    _products.Add(product.Handle, product);
                }
            }
        }

        public IEnumerable<string> Tags
        {
            get
            {
                var tagList = new List<string>();

                foreach (var tags in _products.Values.Select(p => p.Tags))
                {
                    foreach (var tag in tags)
                    {
                        if (!tagList.Contains(tag) && !string.IsNullOrEmpty(tag))
                        {
                            tagList.Add(tag);
                        }
                    }
                }

                return tagList;
            }
        }

        public IEnumerable<string> Types
        {
            get
            {
                return _products.Values.Select(p => p.Type).Distinct();
            }
        }

        public IEnumerable<string> Vendors
        {
            get
            {
                return _products.Values.Select(p => p.Vendor).Distinct();
            }
        }

        public IEnumerable<ShopifyProduct> Products
        {
            get
            {
                return _products.Values;
            }
        }

        public static ShopifyData Instance
        {
            get
            {
                return _instance ?? (_instance = new ShopifyData());
            }
        }

        #endregion

        #region Private Methods

        private ShopifyData()
        {
            _products = new Dictionary<string, ShopifyProduct>();
        }

        private Dictionary<string, ShopifyProduct> csvToShopifyData(IEnumerable<char> csv)
        {
            var shopifyData = new Dictionary<string, ShopifyProduct>();

            foreach(var line in csvLineToArray(csv))
            {
                var shopifyProductOptions = new ShopifyProductOptions(line[6], line[7], line[8], line[9], line[10], line[11]);
                var shopifyVariant = new ShopifyVariant(line[12], line[13], line[14], line[15], line[16], line[17], line[18],
                                                        line[17], line[18], line[19]);
                var product = new ShopifyProduct(line[0], line[1], line[2], line[3], line[4], line[5].Split(','), shopifyProductOptions, shopifyVariant, line[line.Length - 1]);
                shopifyData.Add(product.Handle, product);
            }

            return shopifyData;
        }

        private static string buildHtmlDescription(string[] filename, ShopifyImportData data)
        {
            var builder = string.Empty;

            if (data.Details.Count > 0 && data.Details[0].Contains("{{"))
            {
                foreach (var detail in data.Details)
                {
                    var line = detail.Replace("{{", string.Empty).Replace("}}", string.Empty);
                    if (!string.IsNullOrEmpty(line))
                    {
                        builder += line + '\n';
                    }
                }
            }
            else
            {
                builder += string.Format("<h4>{0}</h4>", data.DetailsHeader);
                builder += '\n';
                builder += "<ul>";
                builder += '\n';
                foreach (var detail in data.Details)
                {
                    var match = Regex.Match(detail, "{\\d+}");
                    if (match != null)
                    {
                        var num = Regex.Match(match.ToString(), "\\d+");
                        int i;
                        if (Int32.TryParse(num.ToString(), out i) && filename.Length >= i)
                        {
                            builder += string.Format("<li>{0}</li>", detail.Replace(match.ToString(), filename[i - 1].Replace("_", " ")));
                        }
                        else
                        {
                            builder += string.Format("<li>{0}</li>", detail);
                        }
                    }
                    else
                    {
                        builder += string.Format("<li>{0}</li>", detail);
                    }

                    builder += '\n';
                }
                builder += "</ul>";
            }

            builder = builder.Replace("\"", "\"\"");

            return builder;
        }

        private IEnumerable<string[]> csvLineToArray(IEnumerable<char> csv)
        {
            var line = new List<string>();
            var lines = new List<string[]>();
            var tempValue = string.Empty;
            var ignoreCommas = false;
            var columnCounter = 0;

            foreach (var tempChar in csv)
            {
                if ((tempChar == ',' || tempChar == '\n') && !ignoreCommas)
                {
                    columnCounter++;
                    line.Add(tempValue);
                    tempValue = string.Empty;

                    if (columnCounter == _columnCount)
                    {
                        lines.Add(line.ToArray());
                        line.Clear();
                        columnCounter = 0;
                    }
                }
                else if (tempChar == '"')
                {
                    ignoreCommas = !ignoreCommas;
                }
                else
                {
                    tempValue += tempChar;
                }
            }

            return lines;
        }

        private void importProductData(string path, ShopifyImportData data)
        {
            try
            {
                foreach (var fileName in Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly))
                {
                    if (!ValidExtensions.Contains(Path.GetExtension(fileName)))
                    {
                        continue;
                    }

                    var file = Path.GetFileNameWithoutExtension(fileName);
                    var splitfile = file.Split('+');

                    var title = file.Replace("_", " ").Replace("+", ", ");
                    var handle = file.ToLower().Replace("+", "-").Replace("_", "-");

                    for (var i = 0; i < data.Variants.Count; i++)
                    {
                        ShopifyProduct product;
                        if (i == 0)
                        {
                            product = new ShopifyProduct(handle, title, buildHtmlDescription(splitfile, data),
                                                             data.Vendor, data.Type, data.Tags, data.Variants[i].Item1,
                                                             data.Variants[i].Item2,
                                                             data.ImageUrl + Path.GetFileName(fileName));
                        }
                        else
                        {
                            product = new ShopifyProduct(handle, string.Empty, string.Empty,
                                 string.Empty, string.Empty, new string[] {}, data.Variants[i].Item1,
                                 data.Variants[i].Item2, string.Empty);
                        }

                        if (!_products.ContainsKey(product.Handle))
                        {
                            _products.Add(product.Handle, product);
                        }
                        else if (data.Variants.Count > 1)
                        {
                            var newHandle = handle;
                            var iterator = 1;
                            while (_products.ContainsKey(newHandle))
                            {
                                newHandle += string.Format("-variant{0}", iterator++);
                            }
                            _products.Add(newHandle, product);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problems importing information");
            }
        }

        #endregion
    }

    public static class ShopifyImportHelper
    {
        private const string DetailsFile = @"details.txt";
        private const string Vendor = @"vendor:";
        private const string Type = @"type:";
        private const string Tags = @"tags:";
        private const string Price = @"price:";
        private const string Variant = @"variant:";
        private const string Description = @"description:";
        private const string Url = @"url:";

        public static ShopifyImportData GetImportData(string path)
        {
            var detailsFile = Path.Combine(path, DetailsFile);
            return File.Exists(detailsFile) ? getImportData(detailsFile) : null;
        }

        private static ShopifyImportData getImportData(string file)
        {
            var details = new List<string>();
            var description = new List<string>();
            var variants = new List<Tuple<ShopifyProductOptions, ShopifyVariant>>();
            var foundDesc = false;

            using (var reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.ToLower().Contains(Description))
                    {
                        foundDesc = true;
                    }

                    if (foundDesc && !line.ToLower().Contains(Description))
                    {
                        description.Add(line);
                    }
                    else
                    {
                        details.Add(line);
                    }
                }
            }

            var url = details.Where(s => s.IndexOf(Url, StringComparison.OrdinalIgnoreCase) >= 0).FirstOrDefault();
            if (!string.IsNullOrEmpty(url))
            {
                url = Regex.Replace(url, Url, "", RegexOptions.IgnoreCase).Trim();
            }
            var vendor = details.Where(s => s.IndexOf(Vendor, StringComparison.OrdinalIgnoreCase) >= 0).FirstOrDefault();
            if (!string.IsNullOrEmpty(vendor))
            {
                vendor = Regex.Replace(vendor, Vendor, "", RegexOptions.IgnoreCase).Trim();
            }
            var type = details.Where(s => s.IndexOf(Type, StringComparison.OrdinalIgnoreCase) >= 0).FirstOrDefault();
            if (!string.IsNullOrEmpty(type))
            {
                type = Regex.Replace(type, Type, "", RegexOptions.IgnoreCase).Trim();
            }
            var tags = details.Where(s => s.IndexOf(Tags, StringComparison.OrdinalIgnoreCase) >= 0).FirstOrDefault();
            if (!string.IsNullOrEmpty(tags))
            {
                tags = Regex.Replace(tags, Tags, "", RegexOptions.IgnoreCase).Trim();
            }
            var price = details.Where(s => s.IndexOf(Price, StringComparison.OrdinalIgnoreCase) >= 0).FirstOrDefault();
            if (!string.IsNullOrEmpty(price))
            {
                price = Regex.Replace(price, Price, "", RegexOptions.IgnoreCase).Trim();
                var variant = new ShopifyVariant(string.Empty, "0", string.Empty, "1", "deny", "manual", price, string.Empty, "TRUE", "TRUE");
                var productOption = new ShopifyProductOptions("Title", "Default Title", string.Empty, string.Empty, string.Empty, string.Empty);
                variants.Add(new Tuple<ShopifyProductOptions, ShopifyVariant>(productOption, variant));
            }

            foreach (var variant in details.Where(s => s.IndexOf(Variant, StringComparison.OrdinalIgnoreCase) >= 0))
            {
                var vals = Regex.Replace(variant, Variant, "", RegexOptions.IgnoreCase).Trim().Split(',');
                if (vals.Length > 1)
                {
                    var v = new ShopifyVariant(string.Empty, "0", string.Empty, "1", "deny", "manual", vals[1].Trim(), string.Empty, "TRUE", "TRUE");
                    var productOption = new ShopifyProductOptions("Title", vals[0].Trim(), string.Empty, string.Empty, string.Empty, string.Empty);
                    variants.Add(new Tuple<ShopifyProductOptions, ShopifyVariant>(productOption, v));
                }
            }

            string descriptionHeader = null;
            if (description.Count > 0 && !description[0].Contains("{{"))
            {
                descriptionHeader = description[0];
                description.RemoveAt(0);
            }

            var importData = new ShopifyImportData(vendor, type, tags, price, url, descriptionHeader ?? @"Details:", description)
                                 {Variants = variants};
            return importData;
        }

    }
}
