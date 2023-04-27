﻿using Newtonsoft.Json;
using RestSharp;
using System.Net;
using SimplePOSHybrid.Models.GetCustomer;
using static MudBlazor.CategoryTypes;

namespace SimplePOSHybrid.Data
{
    public class CustomerView
    {
        GlobalUsings link = new();

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



    }
}
