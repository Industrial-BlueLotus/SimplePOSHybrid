using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOSHybrid.Models.GetCustomer.Create_Update
{
    public class CreateCstmrModel
    {
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public int isAct { get; set; }
        public string phone { get; set; }
        public string loyaltyCardNo { get; set; }
        public string email { get; set; }
        public string doorNo { get; set; }
        public string adrId { get; set; }
        public string ourCd { get; set; }
        public int companyKey { get; set; }
    }

}
