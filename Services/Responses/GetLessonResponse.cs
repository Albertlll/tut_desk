using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Collections;

namespace tutdesk.Services.Responses
{
    public record GetLessonResponse
    (
        string lessonId,
        string title,
        List<Dictionary<string, string>> context
    )
    {
    }
}
