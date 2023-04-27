
namespace SimplePOSHybrid.Models.GetCustomer.Create_Update
{

    public class CreateCstmrResModel
    {
        public int responseType { get; set; }
        public int totalRecordCount { get; set; }
        public object[] errorMessages { get; set; }
        public Message[] messages { get; set; }
        public Responsedata responseData { get; set; }
        public bool incomplete_results { get; set; }

        public CreateCstmrResModel()
        {
            messages = new Message[0];
        }
    }

    public class Responsedata
    {
    }

    public class Message
    {
        public string message { get; set; }
        public int typeOfMessage { get; set; }
    }

}
