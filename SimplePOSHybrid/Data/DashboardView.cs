using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using RestSharp;
using SimplePOSHybrid.Models.PartnerMenu;
using SimplePOSHybrid.Models.GetCategories;
using SimplePOSHybrid.Models.GetItems;
using SimplePOSHybrid.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Linq;

namespace SimplePOSHybrid.Data
{

    public class DashboardView
    {
        private string apitoken;

        //LoginStateService lss = new LoginStateService();

        private LoginStateService _loginStateService;

        public DashboardView(LoginStateService loginStateService)
        {
            _loginStateService = loginStateService;
        }





        //public RestRequest Res()
        //{
        //    GlobalUsings link = new();
        //    try
        //    {

        //        GetPartnerItemListToUploadReqModel reqmodel = new()
        //        {
        //            RequestId = "7ee53650-37b8-464c-90e9-85d89f8ab12a",
        //            IntegrationId = "7ee53650-37b8-464c-90e9-85d89f8ab12a",
        //            Apikey = "5b9f7f95a73c1b8270ef7cbe664324aac2e9f981f906ad366c64f2b107c90be7"
        //        };

        //        UID te = new()
        //        {
        //            UserKey = 301848,
        //            CompanyKey = 51,
        //            LocationKey = 80916,
        //            EnvironmentName = "Live",
        //            IsUrbanPiper = false
        //        };

        //        reqmodel.UID = te;

        //        Company co = new()
        //        {
        //            CompanyId = 51
        //        };
        //        reqmodel.company = co;


        //        var request = new RestRequest(link.apilinkpub + "api/PartnerMenu/GetPartnerItemListToUpload").AddJsonBody(reqmodel);
        //        request.Method = Method.Post;

        //        request.AddHeader("Accept", "application/json");
        //        request.AddHeader("Authorization", "Bearer " + apitoken);
        //        request.AddHeader("Content-Type", "application/json");
        //        request.AddHeader("TImeStamp", "125635753");

        //        return request;

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //        return new RestRequest();
        //    }

        //}


        public RestRequest Res()
        {
            GlobalUsings link = new();

            apitoken = _loginStateService.GetToken();
            Console.WriteLine(apitoken);

            try
            {

                GetCatgryReqModel reqmodel = new()
                {
                    CompanyKey = 51,
                    CategoryKey = 1
                };


                var request = new RestRequest(link.apilinkpub + "api/Codebase/getCategories").AddJsonBody(reqmodel);
                request.Method = Method.Post;

                request.AddHeader("Accept", "application/json");
                request.AddHeader("Authorization", "Bearer " + apitoken);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("IntegrationID", "7ee53650-37b8-464c-90e9-85d89f8ab12a");

                return request;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new RestRequest();
            }

        }

        public RestRequest ResItm()
        {
            GlobalUsings link = new();

            apitoken = _loginStateService.GetToken();
            Console.WriteLine(apitoken);

            try
            {

                GetCatgryReqModel reqmodel = new()
                {
                    CompanyKey = 51,

                };


                var request = new RestRequest(link.apilinkpub + "api/Item/getPartnerItemList").AddJsonBody(reqmodel);
                request.Method = Method.Post;

                request.AddHeader("Accept", "application/json");
                request.AddHeader("Authorization", "Bearer " + apitoken);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("IntegrationID", "7ee53650-37b8-464c-90e9-85d89f8ab12a");

                return request;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new RestRequest();
            }

        }
        //Configuration
        public async Task<CatgryModel> LoadResponseCat()
        {

            var client = new RestClient();


            try
            {

                RestResponse response = await client.PostAsync(Res());

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseContent = response.Content.ToString();

                    Console.WriteLine(responseContent);

                    CatgryModel array = JsonConvert.DeserializeObject<CatgryModel>(responseContent);
                    return array;

                }

                else
                {
                    Console.WriteLine(response.StatusCode);
                    return new CatgryModel();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return new CatgryModel();

            }

        }

        //Configuration
        public async Task<GetPartnerItemList> LoadResponseItm()
        {

            var client = new RestClient();


            try
            {

                RestResponse response = await client.PostAsync(ResItm());

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseContent = response.Content.ToString();

                    Console.WriteLine(responseContent);

                    GetPartnerItemList itmlst = JsonConvert.DeserializeObject<GetPartnerItemList>(responseContent);
                    return itmlst;

                }

                else
                {
                    Console.WriteLine(response.StatusCode);
                    return new GetPartnerItemList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return new GetPartnerItemList();

            }

        }

        //display items
        public List<Models.GetItems.Value> DisplayItem(GetPartnerItemList te, string category)
        {
            //string catename = category;
            List<Models.GetItems.Value> lst = new();
           
            lst = te.value.Where(x => x.categoryCode == category).ToList();
            //lst = te.ResponseData.MenuItemList.Where(x => x.CategoryCode == catename).ToList();
            return lst;
        }

        //Filtering the categories
        public static List<string> DisplayCat(CatgryModel te)
        {
            List<string> catlst = new();

            try
            {
                catlst = te.value.GroupBy(x => x.categoryName).Select(g => g.Key).ToList();

                //catlst = te.ResponseData.MenuItemList.GroupBy(x => x.CategoryCode).Select(g => g.Key).ToList();

                return catlst;
            }
            catch (Exception e)
            {
                Alert1();
                return new List<string>();
            }


        }

        public static async void Alert1()
        {
            await App.Current.MainPage.DisplayAlert("Oops", "Check Your Connection!", "Cancel");
        }

    }
}