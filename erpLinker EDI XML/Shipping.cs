using System;
using System.Collections.Generic;
using System.Text;

namespace erpLinker_EDI_XML
{
    public class Shipping
    {
        public string Carrier { get; set; } = null;

        public decimal? Costs { get; set; } = null;

        public string TrackingCode { get; set; } = null;
    }
}
