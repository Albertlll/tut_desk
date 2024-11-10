using Avalonia;
using Avalonia.Media.Imaging;
using System.Threading.Tasks;


namespace tutdesk.Models
{
    public class Course
    {
        public Task<Bitmap?> ?Image { get; set; } 
        public string ?Title { get; set; }         // Название курса
        public string ?Description { get; set; }   // Описание курса
        public string ?Icon { get; set; }          // Путь к изображению иконки курса

        // Вы можете добавить дополнительные свойства по необходимости, например:
        public string ?Duration { get; set; }      // Длительность курса
        public string ?Level { get; set; }         // Уровень сложности (начальный, средний, продвинутый)
    }
}
