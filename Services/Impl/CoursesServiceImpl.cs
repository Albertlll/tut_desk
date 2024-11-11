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
    public class CoursesServiceImpl(HttpClient httpClient) : ICoursesService
    {
        public async Task<List<GetCourseResponse>?> GetUserCourses(string userId)
        {
            var response = await httpClient.GetAsync("http://localhost:8080/api/v1/courses/my/" + userId);
            var content = await response.Content.ReadAsStringAsync();
            return response.IsSuccessStatusCode
                ? JsonSerializer.Deserialize<List<GetCourseResponse>>(content) : null;
        }
    }
}
