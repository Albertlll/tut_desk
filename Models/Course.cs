using Avalonia;
using Avalonia.Media.Imaging;
using System.Collections.ObjectModel;
using System.Threading.Tasks;


namespace tutdesk.Models
{
    public class Course
    {
        public Bitmap? Image { get; set; } 
        public string? Title { get; set; }         // Название курса
        public int Progress { get; set; }          // Прогресс курса в процентах

        public ObservableCollection<Module> Modules { get; set; } = new ObservableCollection<Module>();    
    }
}
