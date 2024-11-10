using Avalonia;
using Avalonia.Media.Imaging;
using System.Threading.Tasks;


namespace tutdesk.Models
{
    public class Course
    {
        public Bitmap? Image { get; set; } 
        public string? Title { get; set; }         // Название курса
        public string? Description { get; set; }   // Описание курса
        public string? Icon { get; set; }          // Путь к изображению иконки курса

        public string? LabelText { get; set; }     // Текст для метки, например "CS50x 2024 SQL"
        public int Progress { get; set; }          // Прогресс курса в процентах

        // Вы можете добавить дополнительные свойства по необходимости, например:

        //  public string? Duration { get; set; }      // Длительность курса
        //   public string? Level { get; set; }         // Уровень сложности (начальный, средний, продвинутый)
    }
}
