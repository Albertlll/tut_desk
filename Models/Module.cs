using Avalonia;
using Avalonia.Media.Imaging;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;


namespace tutdesk.Models
{
    public class Module
    {
        public string? Id { get; set; }
        public string? Title { get; set; }         // Название курса

        public ObservableCollection<Lesson>? Lessons { get; set; } //

    }
}
