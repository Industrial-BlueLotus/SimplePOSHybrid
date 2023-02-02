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

        [ObservableProperty]
        public string tab1;




        private readonly string apitoken = "5b9f7f95a73c1b8270ef7cbe664324aac2e9f981f906ad366c64f2b107c90be7";

        string responseContent = string.Empty;
        public DashboardView() { }

        public async Task<Rootobject> LoadResponse()
        {
            GlobalUsings link = new();
            var client = new RestClient();



            try
            {
                GetPartnerItemListToUploadReqModel reqmodel = new()
                {
                    RequestId = "7ee53650-37b8-464c-90e9-85d89f8ab12a",
                    IntegrationId = "7ee53650-37b8-464c-90e9-85d89f8ab12a",
                    Apikey = "5b9f7f95a73c1b8270ef7cbe664324aac2e9f981f906ad366c64f2b107c90be7"
                };

                UID te = new()
                {
                    UserKey = 301848,
                    CompanyKey = 51,
                    LocationKey = 80916,
                    EnvironmentName = "Live",
                    IsUrbanPiper = false
                };

                reqmodel.UID = te;

                Company co = new()
                {
                    CompanyId = 51
                };

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

                    return array;
                    //LItems = new ObservableCollection<Rootobject>((IEnumerable<Rootobject>)array);
                    //Console.WriteLine(LItems);

                }

                else
                {
                    Console.WriteLine(response.StatusCode);
                    return new Rootobject();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return new Rootobject();

            }

        }


        public static string[] insertCat(Rootobject te)
        {
            int n = te.ResponseData.MenuItemList.Length;
            string[] cate = new string[n];


            for (int i = 0; i < n; i++)
            {

                int index = Array.IndexOf(cate, te.ResponseData.MenuItemList[i].CategoryCode);
                if (index.Equals(-1))
                {
                    cate[i] = te.ResponseData.MenuItemList[i].CategoryCode;
                    Console.WriteLine(cate[i]);
                }
                else
                {

                    continue;
                }
            }

            int j = 0;


            for (int i = 0; i < n; i++)
            {
                if (cate[i] != null)
                {

                    j++;

                }
                else
                {
                    continue;
                }
            }


            string[] arr = new string[j];
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                if (cate[i] != null)
                {
                    if (m < j)
                    {
                        arr[m] = cate[i];
                        m++;
                    }

                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(arr);
            return arr;
        }

        


    }
}