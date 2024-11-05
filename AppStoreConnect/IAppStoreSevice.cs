namespace AppStoreConnect;

public interface IAppStoreSevice
{
    Task<string> CreateSubscriptionGroup(string appId, string referenceName);
}
