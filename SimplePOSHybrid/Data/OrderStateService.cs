using SimplePOSHybrid.Models.PartnerMenu;

namespace SimplePOSHybrid.Data
{
    public class OrderStateService
    {
        private IEnumerable<Menuitemlist> Elements = new List<Menuitemlist>();

        private List<Menuitemlist> orderitems = new List<Menuitemlist>();

        private List<Menuitemlist> orderitems1 = new List<Menuitemlist>();

        public OrderStateService() { }
        public IEnumerable<Menuitemlist> ElementMthd(List<Menuitemlist> orderitems)
        {
            Elements = orderitems.AsEnumerable();
            return Elements;
        }

        public List<Menuitemlist> OrderMthd(List<Menuitemlist> orderitems)
        {
            orderitems1 = orderitems;
            return orderitems1;
        }

        public List<Menuitemlist> GetOrderitems()
        {
            return orderitems1;
        }

        public IEnumerable<Menuitemlist> GetElements()
        {
            return Elements;
        }
    }
}
