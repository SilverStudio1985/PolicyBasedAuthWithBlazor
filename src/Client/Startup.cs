using BlazorAuthorization.Client.Services;
using BlazorAuthorization.Shared;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorAuthorization.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) {
            services.AddBlazoredLocalStorage();
            services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddAuthorizationCore(config => {
                config.AddPolicy(Policies.IsAdmin, Policies.IsAdminPolicy());
                config.AddPolicy(Policies.IsUser, Policies.IsUserPolicy());
            });
        }

        public void Configure(IComponentsApplicationBuilder app) {
            app.AddComponent<App>("app");
        }
    }
}
