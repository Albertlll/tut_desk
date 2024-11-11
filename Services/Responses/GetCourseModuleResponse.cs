using System;

namespace tutdesk.Services.Responses
{
    public record GetCourseModuleResponse
    (
        string moduleId,
        string title
    )
    {
    }
}