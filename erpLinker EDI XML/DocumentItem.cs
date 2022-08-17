namespace erpLinker_EDI_XML
{
    public enum EDocumentItemType { Goods = 1, Services = 2, ShippingCosts = 3 };
    public class DocumentItem
    {
        public string SKU { get; set; }

        public string EAN { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string UnitOfMeasure { get; set; }

        public decimal Quantity { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? UnitPriceAfterDiscount { get; set; }

        public decimal? TaxRate { get; set; }

        public string TaxCode { get; set; }

        public decimal? Amount { get; set; }

        public decimal? AmountWithTax { get; set; }

      
        public string PKWiU { get; set; }


        public EDocumentItemType? Type { get; set; } = null;

        public string SerialNumber { get; set; }


        public string CodeCN { get; set; }

        public string CodeGTU { get; set; }


        public decimal? Weight { get; set; } = null;

        public decimal? Height { get; set; } = null;

        public decimal? Width { get; set; } = null;

        public decimal? Depth { get; set; } = null;

        public string Producer { get; set; }
    }
}