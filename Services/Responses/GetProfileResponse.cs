namespace tutdesk.Services.Responses
{
    public record GetProfileResponse
    (
        string email,
        string firstName,
        string lastName,
        string avatarUri
    )
    {

    }
}