using AppStoreConnect.Options;
using Microsoft.Extensions.DependencyInjection;

namespace AppStoreConnect.Extensions;

public static class AppStoreServiceRegistrationExtensions
{
    public static IServiceCollection AddAppStoreService(this IServiceCollection services, Action<AppStoreOptions>? setUpAction = null)
    {
        services.AddOptions();

        if (setUpAction != null)
        {
            services.Configure(setUpAction);
        }

        services.AddTransient<IAppStoreSevice, AppStoreService>();

        return services;
    }
}
