using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOSHybrid.Models.Login
{
    public class NewLoginResModel
    {

        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string token { get; set; }
        public bool isSuccess { get; set; }
        public string userImageURL { get; set; }
    }


}

