using SimplePOSHybrid.Models;
using RestSharp;
using Newtonsoft.Json;

namespace SimplePOSHybrid.Data
{
    public class LoginStateService
    {
        private string UserName;

        private string CompanyName;

        private LoginResModel ResModel = new();

        public LoginResModel LoginStateMethod(RestResponse response)
        {
            string responseContent = response.Content.ToString();
            LoginResModel array = JsonConvert.DeserializeObject<LoginResModel>(responseContent);

            ResModel.ResponseData.User.UserId = array.ResponseData.User.UserId;
            //ResModel.ResponseData.User.UserCompanies.
            return ResModel;
        }


        public LoginStateService() { }


    }
}
