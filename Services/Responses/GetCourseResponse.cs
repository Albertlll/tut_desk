namespace tutdesk.Services.Responses
{
    public record GetCourseResponse
    (
        string courseId,
        string title,
        string avatarUrl,
        int progressPercent
    )
    {
    }
}