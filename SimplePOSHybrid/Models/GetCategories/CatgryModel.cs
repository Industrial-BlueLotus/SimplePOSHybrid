using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOSHybrid.Models.GetCategories
{
    public class CatgryModel
    {
        public Value[] value { get; set; }
        public object[] messages { get; set; }
        public object executionException { get; set; }
        public DateTime executionStarted { get; set; }
        public DateTime executionEnded { get; set; }
        public string responseId { get; set; }

        public CatgryModel()
        {
            value = new Value[0];
        }
    }

    public class Value
    {
        public int ID { set; get; } = 0;
        public int categoryId { get; set; }
        public object company { get; set; }
        public object categoryCode { get; set; }
        public string categoryName { get; set; }
        public bool isDefaultCategory { get; set; }
        public object[] subCategories { get; set; }
        public int parentCategoryId { get; set; }
        public int departmentId { get; set; }
        public int parent2Ky { get; set; }
        public bool isSeperateItemWiseTicket { get; set; }
        public int colorCode { get; set; }
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

        public Value()
        {
            addtionalData = new Addtionaldata();
        }
    }

    public class Addtionaldata
    {
    }

}
