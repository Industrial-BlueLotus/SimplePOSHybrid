using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOSHybrid.Models.GetCustomer
{
    public class CustomerModel
    {
        public CstmValue[] value { get; set; }
        public object[] messages { get; set; }
        public object executionException { get; set; }
        public DateTime executionStarted { get; set; }
        public DateTime executionEnded { get; set; }
        public string responseId { get; set; }
        public List<string> CustomerState { get; set; }
        public CustomerModel()
        {
            value = new CstmValue[0];
            //CustomerState = new List<string>();
        }
    }

    public class CstmValue
    {

        public int posCustomerId { get; set; }
        public object company { get; set; }
        public string customerName { get; set; }
        public string addressId { get; set; }
        public string doorNo { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string cardNo { get; set; }
        public string zipCode { get; set; }
        public string telephone { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string lastOrderDt { get; set; }
        public int adrPrefixKey { get; set; }
        public bool isCus { get; set; }
        public bool isDrv { get; set; }
        public bool isEmployee { get; set; }
        public bool isLoyalty { get; set; }
        public string dateOfBirth { get; set; }
        public object gender { get; set; }
        public int genderId { get; set; }
        public object location { get; set; }
        public int locationId { get; set; }
        public int registeredLocationId { get; set; }
        public string nic { get; set; }
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
        public object owningCompany { get; set; }

        //public CstmValue()
        // {
        //     CustomerState = new List<string>();
        // }
    }

    public class Addtionaldata
    {
    }

}
