using SimplePOSHybrid.Models.PartnerMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOSHybrid.Data
{
    public class OrderStateService
    {
        private List<Menuitemlist> orderitems = new List<Menuitemlist> { };

        public void orderState(Menuitemlist item)
        {
            orderitems.Add(item);
            Console.WriteLine(orderitems);



        }

    }
}
