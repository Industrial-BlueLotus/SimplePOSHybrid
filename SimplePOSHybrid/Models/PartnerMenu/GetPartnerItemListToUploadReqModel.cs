using System;

namespace SimplePOSHybrid.Models.PartnerMenu
{
    public class GetPartnerItemListToUploadReqModel
    {
        public string RequestId { get; set; }
        public string IntegrationId { get; set; }
        public string Apikey { get; set; }
        public UID UID { get; set; }
        public Company company { get; set; }
    }

    public class UID
    {
        public int UserKey { get; set; }
        public int CompanyKey { get; set; }
        public int LocationKey { get; set; }
        public string EnvironmentName { get; set; }
        public bool IsUrbanPiper { get; set; }
    }

    public class Company
    {
        public int CompanyId { get; set; }
    }


}

