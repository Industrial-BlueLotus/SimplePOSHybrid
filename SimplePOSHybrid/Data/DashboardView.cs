using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using RestSharp;
using SimplePOSHybrid.Models.PartnerMenu;
using SimplePOSHybrid.Models.GetCategories;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;

namespace SimplePOSHybrid.Data
{

    public class DashboardView
    {
        private string apitoken;

        private readonly LoginStateService _loginStateService;

        public DashboardView(LoginStateService loginStateService)
        {
            _loginStateService = loginStateService;
        }


        public DashboardView() { }


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


                return request;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new RestRequest();
            }

        }
        //Configuration
        public async Task<CatgryModel> LoadResponse()
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

        //display items
        public static List<Menuitemlist> DisplayItem(ItemModel te, string category)
        {
            string catename = category;
            List<Menuitemlist> lst = new();
            lst = te.ResponseData.MenuItemList.Where(x => x.CategoryCode == catename).ToList();
            return lst;
        }

        //Filtering the categories
        public static List<object> DisplayCat(CatgryModel te)
        {
            List<object> catlst = new();

            try
            {
                catlst = te.value.GroupBy(x => x.categoryCode).Select(g => g.Key).ToList();

                //catlst = te.ResponseData.MenuItemList.GroupBy(x => x.CategoryCode).Select(g => g.Key).ToList();

                return catlst;
            }
            catch (Exception e)
            {
                Alert1();
                return new List<object>();
            }


        }

        public static async void Alert1()
        {
            await App.Current.MainPage.DisplayAlert("Oops", "Check Your Connection!", "Cancel");
        }

    }
}