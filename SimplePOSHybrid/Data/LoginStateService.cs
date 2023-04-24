using SimplePOSHybrid.Models.Login;
using SimplePOSHybrid.Models.UserCompanies;
using RestSharp;
using Newtonsoft.Json;
using System.Net;
using SimplePOSHybrid.Models.GetCustomer;

namespace SimplePOSHybrid.Data
{
    public class LoginStateService
    {
        private NewLoginResModel ResModel = new();

        private UserCompaniesModel usrcompmdl = new();

        private CustomerView customer = new();

        GlobalUsings link = new();

        public async Task<UserCompaniesModel> getUserCompanies(string apitoken)
        {
            var client = new RestClient();

            string responseContent = string.Empty;


            try
            {
                var request = new RestRequest(link.apilinkpub + "api/Authentication/getUserCompanies");
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

                    List<UserCompaniesModel> arr = JsonConvert.DeserializeObject<List<UserCompaniesModel>>(responseContent);
                    usrcompmdl.companyName = arr[0].companyName;
                    return usrcompmdl;

                }
                return new UserCompaniesModel();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return new UserCompaniesModel();

                //await _navigation.PushAsync(new AlertPop());

            }

        }



        public async Task<NewLoginResModel> LoginStateMethodAsync(RestResponse response)
        {
            string responseContent = response.Content.ToString();
            NewLoginResModel array = JsonConvert.DeserializeObject<NewLoginResModel>(responseContent);

            ResModel.username = array.username;
            ResModel.token = array.token;
            await getUserCompanies(array.token);
            await customer.getCustomers(array.token);

            return ResModel;
        }


        public LoginStateService() { }

        public string GetUserName()
        {
            return ResModel.username;
        }

        public string GetUserCompany()
        {
            return usrcompmdl.companyName;
        }

        public string GetToken()
        {
            return ResModel.token;
        }
    }



    //public class LoginStateService
    //{
    //    private LoginResModel ResModel = new();

    //    public LoginResModel LoginStateMethod(RestResponse response)
    //    {
    //        string responseContent = response.Content.ToString();
    //        LoginResModel array = JsonConvert.DeserializeObject<LoginResModel>(responseContent);

    //        ResModel.ResponseData.User.UserId = array.ResponseData.User.UserId;
    //        ResModel.ResponseData.User.UserCompanies = array.ResponseData.User.UserCompanies;
    //        Console.WriteLine(ResModel.ResponseData.User.UserId);


    //        return ResModel;
    //    }


    //    public LoginStateService() { }

    //    public string GetUserName()
    //    {
    //        return ResModel.ResponseData.User.UserId;
    //    }

    //    public Usercompany GetUserCompany()
    //    {
    //        return ResModel.ResponseData.User.UserCompanies[0];
    //    }
    //}
}
