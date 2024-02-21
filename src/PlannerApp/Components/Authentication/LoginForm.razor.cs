using Microsoft.AspNetCore.Components;
using PlannerApp.Shared.Models;

namespace PlannerApp.Components
{
    public partial class LoginForm : ComponentBase
    {
        [Inject]
        public HttpClient HttpClient { get; set; }
        private LoginRequest _model = new LoginRequest();

        private async Task LoginUserAsync()
        {
            throw new NotImplementedException();
        }
    }
}
