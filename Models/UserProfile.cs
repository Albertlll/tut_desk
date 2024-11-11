using Avalonia.Media.Imaging;

namespace tutdesk.Models
{
    public class UserProfile
    {
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Bitmap? Avatar { get; set; }
    }
}
