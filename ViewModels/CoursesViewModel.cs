using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using tutdesk.Helpers;
using tutdesk.Models;
using tutdesk.Services;

namespace tutdesk.ViewModels
{
    public partial class CoursesViewModel : ViewModelBase
    {

        public ObservableCollection<Course> Courses { get; } = new ObservableCollection<Course>();

        private DataService _dataService;

        public CoursesViewModel(DataService service) : base(service)
        {
            _dataService = service;
            // _dataService.PropertyChanged += OnSelectedCourseChanged;
            

            ImageHelper.LoadFromWeb(new Uri("https://upload.wikimedia.org/wikipedia/commons/4/41/NewtonsPrincipia.jpg")).ContinueWith((task) => {
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result, Progress = 50, Modules = new string[] {"1", "2", "3", "4", "5"}});
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });
                Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = task.Result });

            });
            // Courses.Add(new Course { Title = "Курс 1", Description = "Описание курса 1", Image = ImageHelper.LoadFromWeb(new Uri("https://upload.wikimedia.org/wikipedia/commons/4/41/NewtonsPrincipia.jpg")).Result});
            // Courses.Add(new Course { Title = "Курс 2", Description = "Описание курса 2", Image = ImageHelper.LoadFromWeb(new Uri("https://upload.wikimedia.org/wikipedia/commons/4/41/NewtonsPrincipia.jpg")).Result});
            // Courses.Add(new Course { Title = "Курс 3", Description = "Описание курса 2", Image = ImageHelper.LoadFromWeb(new Uri("https://upload.wikimedia.org/wikipedia/commons/4/41/NewtonsPrincipia.jpg")).Result});
        }


        [ObservableProperty]
        private Course? selectedCourse;

        partial void OnSelectedCourseChanged(Course? value)
        {
            _dataService.SelectedCourse = value;
        }


        // private void OnSelectedCourseChanged(object sender, PropertyChangedEventArgs e)
        // {
        //     Console.WriteLine("Чек");
        //     if (e.PropertyName == nameof(DataService.SelectedCourse))
        //     {
        //             // Если изменилось свойствSharedDataо SharedData, обновляем его значение в текущем ViewModel
        //             SelectedCourse = _dataService.SelectedCourse; // Обновляем значение свойства в ViewModel            
        //     }
        // }




        // public void Cleanup()
        // {
        //     _dataService.PropertyChanged -= OnSelectedCourseChanged;
        // }



        // [RelayCommand]
        // private void ChangeSelectedCourse(Course? newCourse)
        // {
        //     SelectedCourse = newCourse; 
        //     _dataService.SelectedCourse = newCourse; 
        // }

        // public IRelayCommand SelectCourseCommand { get; }








    }
}
