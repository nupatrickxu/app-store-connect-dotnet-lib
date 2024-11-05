using Microsoft.Extensions.Options;

namespace AppStoreConnect.Options;

public class AppStoreOptions : IOptions<AppStoreOptions>
{
    /// <summary>
    /// Key Id of the ios application registered on the dev account
    /// </summary>
    public required string KeyId { get; set; }

    /// <summary>
    /// Issuer Id of the apple dev account
    /// </summary>
    public required string IssuerId { get; set; }

    /// <summary>
    /// Path to the private key file
    /// </summary>
    public required string PrivateKeyPath { get; set; }

    /// <summary>
    /// Set expiration period for the generated token
    /// Default: 20 mins
    /// </summary>
    public int ExpirationMinutes { get; set; } = 20;

    AppStoreOptions IOptions<AppStoreOptions>.Value => this;
}
