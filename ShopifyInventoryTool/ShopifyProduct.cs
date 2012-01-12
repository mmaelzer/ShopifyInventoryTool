using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopifyInventoryTool
{
    public class ShopifyProduct
    {
        public ShopifyProduct(string handle, string title, string details, string vendor, string type, string[] tags, ShopifyProductOptions options, ShopifyVariant variant, string imageSource)
        {
            Handle = handle;
            Title = title;
            Details = details;
            Vendor = vendor;
            Type = type;
            Tags = tags;
            Variant = variant;
            Options = options;
            ImageSource = imageSource;
        }

        public string Handle
        {
            get;
            private set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Details
        {
            get; set;
        }

        public string Price
        {
            get
            {
                return Variant.Price;
            }
            set
            {
                Variant.Price = value;
            }
        }

        public string Vendor
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string[] Tags
        {
            get;
            set;
        }

        public ShopifyProductOptions Options
        {
            get;
            set;
        }

        public ShopifyVariant Variant
        {
            get;
            private set;
        }

        public string ImageSource
        {
            get;
            set;
        }

        public string CsvEntry
        {
            get
            {
                var strings = new List<string>
                                  {
                                      Handle,
                                      Title,
                                      Details,
                                      Vendor,
                                      Type,
                                      string.Join(",", Tags),
                                      Options.OptionOneName,
                                      Options.OptionOneValue,
                                      Options.OptionTwoName,
                                      Options.OptionTwoValue,
                                      Options.OptionThreeName,
                                      Options.OptionThreeValue,
                                      Variant.Sku,
                                      Variant.Grams,
                                      Variant.InventoryTracker,
                                      Variant.InventoryQty,
                                      Variant.InventoryPolicy,
                                      Variant.FulfillmentService,
                                      Variant.Price,
                                      Variant.CompareAtPrice,
                                      Variant.RequiresShipping,
                                      Variant.Taxable,
                                      ImageSource
                                  };

                var builder = string.Empty;
                var counter = 0;
                foreach (var s in strings)
                {
                    var value = s;
                    if (value.Contains(",") || value.Contains('\n'))
                    {
                        value = "\"" + value + "\"";
                    }

                    if (counter != strings.Count - 1)
                    {
                        value += ",";
                    }

                    builder += value;
                    counter++;
                }

                return builder.ToString();
            }
        }
    }

    public class ShopifyProductOptions
    {
        public ShopifyProductOptions(string optionOneName, string optionOneValue, string optionTwoName, string optionTwoValue, string optionThreeName, string optionThreeValue)
        {
            OptionOneName = optionOneName;
            OptionOneValue = optionOneValue;
            OptionTwoName = optionTwoName;
            OptionTwoValue = optionTwoValue;
            OptionThreeName = optionThreeName;
            OptionThreeValue = optionThreeValue;
        }

        public string OptionOneName
        {
            get;
            private set;
        }

        public string OptionOneValue
        {
            get;
            private set;
        }

        public string OptionTwoName
        {
            get;
            private set;
        }

        public string OptionTwoValue
        {
            get;
            private set;
        }

        public string OptionThreeName
        {
            get;
            private set;
        }

        public string OptionThreeValue
        {
            get;
            private set;
        }
    }

    public class ShopifyVariant
    {
        public ShopifyVariant(string sku, string grams, string inventoryTracker, string inventoryQty, string inventoryPolicy,
            string fulfillmentService, string price, string compareAtPrice, string requiresShipping, string taxable)
        {
            Sku = sku;
            Grams = grams;
            InventoryTracker = inventoryTracker;
            InventoryQty = inventoryQty;
            InventoryPolicy = inventoryPolicy;
            FulfillmentService = fulfillmentService;
            Price = price;
            CompareAtPrice = compareAtPrice;
            RequiresShipping = requiresShipping;
            Taxable = taxable;
        }

        public string Sku
        {
            get;
            set;
        }

        public string Grams
        {
            get;
            set;
        }

        public string InventoryTracker
        {
            get;
            set;
        }

        public string InventoryQty
        {
            get;
            set;
        }

        public string InventoryPolicy
        {
            get;
            set;
        }

        public string FulfillmentService
        {
            get;
            set;
        }

        public string Price
        {
            get;
            set;
        }

        public string CompareAtPrice
        {
            get;
            set;
        }

        public string RequiresShipping
        {
            get;
            set;
        }

        public string Taxable
        {
            get;
            set;
        }
    }

    public class ShopifyImportData
    {
        public ShopifyImportData(string vendor, string type, string tags, string price, string url, string dHeader, List<string> details)
        {
            Vendor = vendor ?? string.Empty;
            Type = type ?? string.Empty;
            Tags = tags == null ? new string[] {} : tags.Split(',');
            Price = price ?? string.Empty;
            ImageUrl = url ?? string.Empty;
            DetailsHeader = dHeader ?? string.Empty;
            Details = details ?? new List<string>();
        }

        public string Vendor
        {
            get; private set;
        }

        public string Price
        {
            get; private set;
        }

        public string Type
        {
            get; private set;
        }

        public string[] Tags
        {
            get; private set;
        }

        public string ImageUrl
        {
            get; private set;
        }

        public string DetailsHeader
        {
            get; private set;
        }

        public List<string> Details
        {
            get; private set;
        }

        public List<Tuple<ShopifyProductOptions, ShopifyVariant>> Variants
        {
            get; set;
        }
    }
}
