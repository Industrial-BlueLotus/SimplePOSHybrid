using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOSHybrid.Models.UserCompanies
{
    public class UserCompaniesModel
    {
        public int companyKey { get; set; }
        public string companyName { get; set; }
        public string companyCode { get; set; }
        public int isActive { get; set; }
        public int isApproved { get; set; }
        public bool isRecordLocked { get; set; }
        public bool isPersisted { get; set; }
        public bool isDirty { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
        public DateTime effectiveDate { get; set; }
        public Addtionaldata addtionalData { get; set; }
        public bool isDefault { get; set; }
        public int requestingObjectKey { get; set; }

        public UserCompaniesModel()
        {
            addtionalData = new Addtionaldata();
        }
    }

    public class Addtionaldata
    {

    }
}



