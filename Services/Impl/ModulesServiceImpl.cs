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
    internal class ModulesServiceImpl(HttpClient httpClient) : IModulesService
    {
        public async Task<List<GetCourseModuleResponse>?> GetCourseModules(string courseId)
        {
            var response = await httpClient.GetAsync("http://localhost:8080/api/v1/modules/" + courseId);
            var content = await response.Content.ReadAsStringAsync();
            return response.IsSuccessStatusCode
                ? JsonSerializer.Deserialize<List<GetCourseModuleResponse>>(content) : null;
        }
    }
}
