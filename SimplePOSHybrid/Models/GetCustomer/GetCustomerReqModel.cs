using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOSHybrid.Models.GetCustomer
{
    public class GetCustomerReqModel
    {
        public int companyId { get; set; }
        public string searchQuery { get; set; }
    }

}

