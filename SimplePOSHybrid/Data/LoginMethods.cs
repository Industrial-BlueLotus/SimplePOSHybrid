using Microsoft.AspNetCore.Components;

namespace SimplePOSHybrid.Data
{
    public class LoginMethods
    {
        [Inject]
        public NavigationManager Navigation { get; set; }


        public void LoginResponse()
        {

            Navigation.NavigateTo("/home");

        }
    }
}
