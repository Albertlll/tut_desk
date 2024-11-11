using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using tutdesk.Services.Responses;

namespace tutdesk.Services.Impl
{
    public class LessonServiceImpl(HttpClient httpClient) : ILessonService
    {
        public async Task<List<GetLessonResponse>?> GetModuleLessons(string moduleId)
        {
            var response = await httpClient.GetAsync("http://localhost:8080/api/v1/lessons/" + moduleId);
            var content = await response.Content.ReadAsStringAsync();
            return response.IsSuccessStatusCode
                ? JsonSerializer.Deserialize<List<GetLessonResponse>>(content) : null;
        }
    }
}
