using Newtonsoft.Json;
using RestSharp;
using SimplePOSHybrid.Models.GetCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOSHybrid.Data
{
    public class CustomerStateServices
    {
        private CustomerModel CustomerModel1 = new();

        public CustomerStateServices() { }

        //Filtering the customers
        public static List<string> Filtercstmr(CustomerModel cust)
        {
            List<string> customerlst = new();

            try
            {
                //customerlst = cust.value.GroupBy(x => x.address).Select(x => x.).ToList();
                var groups = cust.value.GroupBy(c => c.address)
                      .Select(g => new { address = g.Key, customerName = g.Select(c => c.customerName).ToList() })
                      .ToList();

                List<string> customerNames = new List<string>();
                foreach (var group in groups)
                {
                    customerNames.AddRange(group.customerName);
                }

                return customerNames;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<string>();
            }


        }


        public async Task<CustomerModel> StateCustomer(RestResponse response)
        {
            try
            {
                List<string> strings = new List<string>();

                string responseContent = response.Content.ToString();
                CustomerModel customerArray = JsonConvert.DeserializeObject<CustomerModel>(responseContent);
                strings = Filtercstmr(customerArray);

                CustomerModel1.CustomerState = strings;
                return CustomerModel1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        public List<string> GetCustomer()
        {
            return CustomerModel1.CustomerState;
        }
    }
}
