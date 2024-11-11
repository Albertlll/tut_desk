namespace tutdesk.Services.Responses
{
    public record AuthenticateResponse
    (
        string userId,
        string username,
        string email
    )
    {

    }
}