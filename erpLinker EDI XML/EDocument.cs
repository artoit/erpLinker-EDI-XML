using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace erpLinker_EDI_XML
{
    public enum EDocumentType { SalesInvoice = 1, PurchaseInvoice = 2, Order = 3, OrderToSupplier = 4, Receipt = 5, StockIssueConfirm_CI = 6, GoodsReceivedNote_GRN = 7, ProForma = 8 }

    public class EDocument
    {
        public EDocumentType? Type { get; set; } = null;


        public int? Number { get; set; } = null;

        public string NumberFull { get; set; }

        public string NumberExternal { get; set; }


        public string CreationDate { get; set; } = DateTime.Now.ToString();

        [XmlIgnore]
        public DateTime CreationDateField
        {
            get
            {
                if (DateTime.TryParse(CreationDate, out DateTime d))
                {
                    return d;
                }

                return DateTime.Now;
            }
            set
            {
                CreationDate = value.ToString();
            }
        }

        public string DeliveryDate { get; set; } = null;

        [XmlIgnore]
        public DateTime? DeliveryDateField
        {
            get
            {
                if (DateTime.TryParse(DeliveryDate, out DateTime d))
                {
                    return d;
                }

                return null;
            }
            set
            {
                DeliveryDate = value.ToString();
            }
        }


        public string Currency { get; set; }

        public string PaymentTypeName { get; set; }

        public string PaymentDueDate { get; set; } = null;

        [XmlIgnore]
        public DateTime? PaymentDueDateField
        {
            get
            {
                if (DateTime.TryParse(PaymentDueDate, out DateTime d))
                {
                    return d;
                }

                return null;
            }
            set
            {
                PaymentDueDate = value.ToString();
            }
        }



        public string Description { get; set; }

        public List<string> JPK_Codes { get; set; } = new List<string>();


        public AddressData Buyer { get; set; }

        public AddressData DeliveryAddress { get; set; }

        public AddressData Seller { get; set; }

        public AddressData Payer { get; set; }



        public List<DocumentItem> Items { get; set; } = new List<DocumentItem>();

        public Shipping Shipping { get; set; } = null;

        public Summary Summary { get; set; } = new Summary();
    }
}
