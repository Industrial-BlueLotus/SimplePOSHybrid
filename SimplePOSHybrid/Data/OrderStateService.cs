using SimplePOSHybrid.Models.PartnerMenu;

namespace SimplePOSHybrid.Data
{
    public class OrderStateService
    {
        private IEnumerable<Menuitemlist> Elements = new List<Menuitemlist>();

        public IEnumerable<Menuitemlist> ElementMthd(List<Menuitemlist> orderitems)
        {
            Elements = orderitems.AsEnumerable();
            return Elements;
        }

        public IEnumerable<Menuitemlist> GetElements()
        {
            return Elements;
        }
    }
}
