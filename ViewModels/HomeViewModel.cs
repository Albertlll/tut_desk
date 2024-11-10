using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using tutdesk.Helpers;
using tutdesk.Models;

namespace tutdesk.ViewModels
{
    public class HomeViewModel : ReactiveObject
    {
        public ObservableCollection<Course> Courses { get; } = new ObservableCollection<Course>();

        public HomeViewModel()
        {

            ImageHelper.LoadFromWeb(new Uri("https://upload.wikimedia.org/wikipedia/commons/4/41/NewtonsPrincipia.jpg")).ContinueWith((task) => {
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
            });
            // Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = ImageHelper.LoadFromWeb(new Uri("https://upload.wikimedia.org/wikipedia/commons/4/41/NewtonsPrincipia.jpg")).Result});
            // Courses.Add(new Course { Title = "Курс 2", Description = "Описание курса 2", Image = ImageHelper.LoadFromWeb(new Uri("https://upload.wikimedia.org/wikipedia/commons/4/41/NewtonsPrincipia.jpg")).Result});
            // Courses.Add(new Course { Title = "Курс 3", Description = "Описание курса 2", Image = ImageHelper.LoadFromWeb(new Uri("https://upload.wikimedia.org/wikipedia/commons/4/41/NewtonsPrincipia.jpg")).Result});

        }
    }
}
