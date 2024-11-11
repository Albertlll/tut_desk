using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using tutdesk.Services.Responses;

namespace tutdesk.Services.Impl
{
    public class LoginServiceImpl(HttpClient httpClient) : ILoginService
    {
        public async Task<AuthenticateResponse?> Authenticate(string email, string password)
        {
            var response = await httpClient.PostAsync("http://localhost:8080/api/v1/auth/login", JsonContent.Create(
                new { email, password }
            ));
            var content = await response.Content.ReadAsStringAsync();
            return response.IsSuccessStatusCode
                ? JsonSerializer.Deserialize<AuthenticateResponse>(content) : null;
        }
    }
}
