using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using RestSharp;
using SimplePOSHybrid.Models.PartnerMenu;
using System.Collections.ObjectModel;
using System.Net;

namespace SimplePOSHybrid.Data
{
    public partial class DashboardView : ObservableObject
    {

        [ObservableProperty]
        ObservableCollection<Rootobject> _LItems;

        private readonly string apitoken = "5b9f7f95a73c1b8270ef7cbe664324aac2e9f981f906ad366c64f2b107c90be7";


        public DashboardView() { }

        public async void LoadResponse()
        {
            GlobalUsings link = new();
            var client = new RestClient();



            try
            {
                GetPartnerItemListToUploadReqModel reqmodel = new();

                reqmodel.RequestId = "7ee53650-37b8-464c-90e9-85d89f8ab12a";
                reqmodel.IntegrationId = "7ee53650-37b8-464c-90e9-85d89f8ab12a";
                reqmodel.Apikey = "5b9f7f95a73c1b8270ef7cbe664324aac2e9f981f906ad366c64f2b107c90be7";

                UID te = new();

                te.UserKey = 301848;
                te.CompanyKey = 51;
                te.LocationKey = 80916;
                te.EnvironmentName = "Live";
                te.IsUrbanPiper = false;

                reqmodel.UID = te;

                Company co = new();

                co.CompanyId = 51;

                reqmodel.company = co;




                var request = new RestRequest(link.apilinkpub + "api/PartnerMenu/GetPartnerItemListToUpload").AddJsonBody(reqmodel);
                request.Method = Method.Post;

                request.AddHeader("Accept", "application/json");
                request.AddHeader("Authorization", "Bearer " + apitoken);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("TImeStamp", "125635753");

                RestResponse response = await client.PostAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseContent = response.Content.ToString();

                    Console.WriteLine(responseContent);

                    Rootobject array = JsonConvert.DeserializeObject<Rootobject>(responseContent);
                    //Console.WriteLine(array);
                    Console.WriteLine(array.ResponseData.MenuItemList[0].CategoryCode);
                    //LItems = new ObservableCollection<Rootobject>((IEnumerable<Rootobject>)array);
                    //Console.WriteLine(LItems);

                }
                else if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    Console.WriteLine(response.StatusCode);
                }
                else
                {
                    Console.WriteLine(response.StatusCode);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}