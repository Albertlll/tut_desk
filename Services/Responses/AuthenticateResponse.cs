namespace tutdesk.Services.Responses
{
    public record AuthenticateResponse
    (
        string Id,
        string Email,
        string Password
    )
    {

    }
}