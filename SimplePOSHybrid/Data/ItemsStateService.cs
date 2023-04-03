using Newtonsoft.Json;
using RestSharp;
using SimplePOSHybrid.Models.PartnerMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOSHybrid.Data
{
    public class ItemsStateService
    {

        ItemModel itemModel = new ItemModel();
        List<Menuitemlist> lst = new();
        List<string> catlst = new();

        public ItemModel ItemsStateMethod(RestResponse response)
        {
            string responseContent = response.Content.ToString();
            itemModel = JsonConvert.DeserializeObject<ItemModel>(responseContent);


            return itemModel;
        }

        //display items
        public List<Menuitemlist> DisplayItem(ItemModel te, string category)
        {
            string catename = category;

            lst = te.ResponseData.MenuItemList.Where(x => x.CategoryCode == catename).ToList();
            return lst;
        }

        public List<Menuitemlist> GetItem()
        {

            return lst;
        }

        //Filtering the categories
        public List<string> DisplayCat(ItemModel te)
        {


            try
            {
                catlst = te.ResponseData.MenuItemList.GroupBy(x => x.CategoryCode).Select(g => g.Key).ToList();

                return catlst;
            }
            catch (Exception e)
            {
                Alert1();
                return new List<string>();
            }


        }

        public List<string> GetCat()
        {
            return catlst;
        }

        public static async void Alert1()
        {
            await App.Current.MainPage.DisplayAlert("Oops", "Check Your Connection!", "Cancel");
        }
    }
}
