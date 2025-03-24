using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class NgsCommon
    {
        public string SellerId { get; set; } // DAACommon의 경우 포함
        public string SupplierId { get; set; } // DAACommon의 경우 포함
        public string SupplierCode { get; set; } // DAACommon의 경우 포함
        public string Pcc { get; set; } // NGSCommon의 경우 포함
        public string PartnerCode { get; set; }
        public string ChannelNo { get; set; }
    }
}