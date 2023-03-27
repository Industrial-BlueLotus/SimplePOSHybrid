using SimplePOSHybrid.Models;
using RestSharp;
using Newtonsoft.Json;

namespace SimplePOSHybrid.Data
{
    public class LoginStateService
    {
        //private string UserName { get; set; }

        //private string CompanyName;

        private LoginResModel ResModel = new();

        public LoginResModel LoginStateMethod(RestResponse response)
        {
            string responseContent = response.Content.ToString();
            LoginResModel array = JsonConvert.DeserializeObject<LoginResModel>(responseContent);

            ResModel.ResponseData.User.UserId = array.ResponseData.User.UserId;
            ResModel.ResponseData.User.UserCompanies = array.ResponseData.User.UserCompanies;
            Console.WriteLine(ResModel.ResponseData.User.UserId);


            return ResModel;
        }


        public LoginStateService() { }

        public string GetUserName()
        {
            return ResModel.ResponseData.User.UserId;
        }

        public Usercompany GetUserCompany()
        {
            return ResModel.ResponseData.User.UserCompanies[0];
        }
    }
}
