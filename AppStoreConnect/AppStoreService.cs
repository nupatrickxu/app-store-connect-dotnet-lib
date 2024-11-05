
using AppStoreConnect.Options;
using Microsoft.Extensions.Options;

namespace AppStoreConnect;

public class AppStoreService : IAppStoreSevice
{
    private readonly AppStoreOptions _options;

    public AppStoreService(IOptions<AppStoreOptions> options)
    {
        _options = options.Value;
    }

    public Task<string> CreateSubscriptionGroup(string appId, string referenceName)
    {
        throw new NotImplementedException();
    }
}
