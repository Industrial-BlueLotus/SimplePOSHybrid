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
        public List<Menuitemlist> orderitems { get; set; }

        public void orderState(Menuitemlist item)
        {
            orderitems.Add(item);


        }

    }
}
