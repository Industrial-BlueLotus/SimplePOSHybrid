using Newtonsoft.Json;
using RestSharp;
using System.Net;
using SimplePOSHybrid.Models.GetCustomer;
using static MudBlazor.CategoryTypes;
using SimplePOSHybrid.Models.GetCustomer.Create_Update;

namespace SimplePOSHybrid.Data
{
    public class CustomerView
    {
        readonly GlobalUsings link = new();

        public CustomerStateServices _customerStateService = new CustomerStateServices();
        public CustomerView(CustomerStateServices customerStateService)
        {
            _customerStateService = customerStateService;
        }

        public CustomerView()
        {
        }

        public async Task<string> CustomersRequest(string apitoken)
        {
            var client = new RestClient();

            string responseContent = string.Empty;

            try
            {
                GetCustomerReqModel getCustomerReqModel = new GetCustomerReqModel
                {
                    companyId = 51,
                    searchQuery = ""
                };



                var request = new RestRequest(link.apilinkpub + "api/Address/getCustomers").AddJsonBody(getCustomerReqModel);
                request.Method = Method.Post;

                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Bearer " + apitoken);
                request.AddHeader("IntegrationID", "7ee53650-37b8-464c-90e9-85d89f8ab12a");

                RestResponse response = await client.PostAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    responseContent = response.Content.ToString();
                    Console.WriteLine(responseContent);


                    await _customerStateService.StateCustomer(response);
                    //Filtercstmr(customerArray);
                    //return customerArray;


                }
                return responseContent;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return responseContent;

                //await _navigation.PushAsync(new AlertPop());

            }

        }

        //public async Task<string> CreateCustomer(CreateCstmrModel createCstmrModel, string apitoken)
        public async Task<string> CreateCustomer(string apitoken)
        {
            string responseContent = string.Empty;
            try
            {
                var client = new RestClient();



                CreateCstmrModel createCstmrModel = new()
                {
                    name = "adam",
                    address = "abc",
                    city = "colombo",
                    postalCode = "12345",
                    isAct = 1,
                    phone = "0711234657",
                    loyaltyCardNo = "az25",
                    email = "adam@gmail.com",
                    doorNo = "1",
                    adrId = "",
                    ourCd = "CUS",
                    companyKey = 51
                };

                var request = new RestRequest(link.apilinkpub + "api/Address/createCustomer").AddJsonBody(createCstmrModel);
                request.Method = Method.Post;

                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Bearer " + apitoken);
                request.AddHeader("IntegrationID", "7ee53650-37b8-464c-90e9-85d89f8ab12a");

                RestResponse response = await client.PostAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    responseContent = response.Content.ToString();
                    Console.WriteLine(responseContent);

                }
                return responseContent;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return responseContent;

            }



        }
    }
}
