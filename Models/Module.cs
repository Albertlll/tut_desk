using Avalonia;
using Avalonia.Media.Imaging;
using System.Threading.Tasks;


namespace tutdesk.Models
{
    public class Module
    {
        public string? Title { get; set; }         // Название курса

        public Lesson[]? Lessons { get; set; } //

    }
}
