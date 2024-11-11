using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using tutdesk.Services.Responses;

namespace tutdesk.Services.Impl
{
    public class UserProfileServiceImpl(HttpClient httpClient) : IUserProfileService
    {
        public async Task<GetProfileResponse?> GetProfileInfo(string userId)
        {
            var response = await httpClient.GetAsync("http://localhost:8080/api/v1/user/profile/" + userId);
            var content = await response.Content.ReadAsStringAsync();
            return response.IsSuccessStatusCode
                ? JsonSerializer.Deserialize<GetProfileResponse>(content) : null;
        }
    }
}
