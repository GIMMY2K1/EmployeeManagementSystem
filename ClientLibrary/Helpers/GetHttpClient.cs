using BaseLibrary.DTOs;

namespace ClientLibrary.Helpers;

public class GetHttpClient
{

    private const string HeaderKey = "Authentication";

    public async Task<HttpClient> GetPrivateHttpClient(IHttpClientFactory httpClientFactory, LocalStorageService localStorageService)
    {
        var client = httpClientFactory.CreateClient("SystemApiClient");
        var stringToken = await localStorageService.GetToken();
        if (string.IsNullOrEmpty(stringToken)) return client;

        var deserializeToken = Serializations.DeserializeJsonString<UserSession>(stringToken);
        if (deserializeToken == null) return client;

        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", deserializeToken.Token);
        return client;
    }

}
