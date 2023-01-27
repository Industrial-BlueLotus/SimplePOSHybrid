using Microsoft.AspNetCore.Components;

namespace SimplePOSHybrid.Data
{
    public class LoginMethods
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }


        public void LoginResponse()
        {

            NavigationManager.NavigateTo("/home");

        }
    }
}
