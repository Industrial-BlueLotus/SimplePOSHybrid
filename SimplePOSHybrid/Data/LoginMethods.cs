using RestSharp;
using SimplePOSHybrid.Models;
using System.Net;
using SimplePOSHybrid.Data;



namespace SimplePOSHybrid.Data
{
    public class LoginMethods
    {
        readonly GlobalUsings link = new();

        private readonly LoginStateService _loginStateService;
        public LoginMethods(LoginStateService loginStateService)
        {
            _loginStateService = loginStateService;
        }

        //public async Task<string> Authenticate(LoginObj logobj)
        //{
        //    var client = new RestClient();

        //    string responseContent = string.Empty;


        //    try
        //    {
        //        var request = new RestRequest(link.apilinkpub + "api/Login/ValidateLogin").AddJsonBody(logobj);
        //        request.Method = Method.Post;

        //        request.AddHeader("Accept", "application/json");
        //        request.AddHeader("Content-Type", "application/json");

        //        RestResponse response = await client.PostAsync(request);

        //        if (response.StatusCode == HttpStatusCode.OK)
        //        {
        //            responseContent = response.Content.ToString();
        //            Console.WriteLine(responseContent);
        //            //LoginStateService loginStateService = new();
        //            _loginStateService.LoginStateMethod(response);



        //        }
        //        return responseContent;

        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex);
        //        return responseContent;

        //        //await _navigation.PushAsync(new AlertPop());

        //    }


        //}

        public async Task<string> Authenticate(LoginObj logobj)
        {
            var client = new RestClient();

            string responseContent = string.Empty;


            try
            {
                var request = new RestRequest(link.apilinkpub + "api/Authentication/authenticate").AddJsonBody(logobj);
                request.Method = Method.Post;

                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("IntegrationID", "7ee53650-37b8-464c-90e9-85d89f8ab12a");

                RestResponse response = await client.PostAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    responseContent = response.Content.ToString();
                    Console.WriteLine(responseContent);
                    //LoginStateService loginStateService = new();
                    _loginStateService.LoginStateMethod(response);



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
