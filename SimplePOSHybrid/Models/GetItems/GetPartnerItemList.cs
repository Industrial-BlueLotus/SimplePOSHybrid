using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOSHybrid.Models.GetItems
{
    public class GetPartnerItemList
    {
        public ItmValue[] value { get; set; }
        public object[] messages { get; set; }
        public object executionException { get; set; }
        public DateTime executionStarted { get; set; }
        public DateTime executionEnded { get; set; }
        public string responseId { get; set; }

        public GetPartnerItemList()
        {
            value = new ItmValue[0];
        }
    }

    public class ItmValue
    {
        public int ID { set; get; } = 0;
        public static string itemImage { get; set; }
        public string ItemImageUrl { get; set; } = string.Format("data:image/svg+xml;base64,{0}", itemImage);
        public object itemImageUrl { get; set; }
        public string itemName { get; set; }
        public int itemKey { get; set; }
        public string itemCode { get; set; }
        public string itemShortName { get; set; }
        public string categoryName { get; set; }
        public string categoryCode { get; set; }
        public string ean { get; set; }
        public string description { get; set; }
        public object remarks { get; set; }
        public int costPrice { get; set; }
        public float salesPrice { get; set; }
        public float optionalSalesPrice { get; set; }
        public bool isModifierItem { get; set; }
        public bool isCompositeItem { get; set; }
        public bool isPayemntType { get; set; }
        public int maximumDiscount { get; set; }
        public int vatPercentage { get; set; }
        public bool isAgeVerification { get; set; }
        public string itemComboTitle { get; set; }
        public int sortingOrder { get; set; }
        public string imageArr { get; set; }
        public double qty { get; set; } = 1.0;
        public int isActive { get; set; } = 1;
    }

}
