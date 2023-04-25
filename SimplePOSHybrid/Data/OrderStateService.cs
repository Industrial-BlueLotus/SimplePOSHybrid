using SimplePOSHybrid.Models.PartnerMenu;
using SimplePOSHybrid.Models.GetItems;

namespace SimplePOSHybrid.Data
{
    public class OrderStateService
    {
        private IEnumerable<ItmValue> Elements = new List<ItmValue>();

        private List<ItmValue> orderitems1 = new();

        public OrderStateService() { }
        public IEnumerable<ItmValue> ElementMthd(List<ItmValue> orderitems)
        {
            Elements = orderitems.AsEnumerable();
            return Elements;
        }

        public List<ItmValue> OrderMthd(List<ItmValue> orderitems)
        {
            orderitems1 = orderitems;
            return orderitems1;
        }

        public List<ItmValue> GetOrderitems()
        {
            return orderitems1;
        }

        public IEnumerable<ItmValue> GetElements()
        {
            return Elements;
        }
    }
}
//namespace SimplePOSHybrid.Data
//{
//    public class OrderStateService
//    {
//        private IEnumerable<Menuitemlist> Elements = new List<Menuitemlist>();

//        private List<Menuitemlist> orderitems = new List<Menuitemlist>();

//        private List<Menuitemlist> orderitems1 = new List<Menuitemlist>();

//        public OrderStateService() { }
//        public IEnumerable<Menuitemlist> ElementMthd(List<Menuitemlist> orderitems)
//        {
//            Elements = orderitems.AsEnumerable();
//            return Elements;
//        }

//        public List<Menuitemlist> OrderMthd(List<Menuitemlist> orderitems)
//        {
//            orderitems1 = orderitems;
//            return orderitems1;
//        }

//        public List<Menuitemlist> GetOrderitems()
//        {
//            return orderitems1;
//        }

//        public IEnumerable<Menuitemlist> GetElements()
//        {
//            return Elements;
//        }
//    }
//}
