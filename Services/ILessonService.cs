using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tutdesk.Services.Responses;

namespace tutdesk.Services
{
    public interface ILessonService
    {
        Task<List<GetLessonResponse>?> GetModuleLessons(string moduleId);
    }
}
