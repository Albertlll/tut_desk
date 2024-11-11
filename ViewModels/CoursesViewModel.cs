using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using tutdesk.Helpers;
using tutdesk.Models;
using tutdesk.Services;
using tutdesk.Services.Responses;

namespace tutdesk.ViewModels
{
    public class CoursesViewModel : ReactiveObject
    {
        public ObservableCollection<Course> Courses { get; } = new ObservableCollection<Course>();
        private ICoursesService coursesService;

        public CoursesViewModel(ICoursesService coursesService)
        {
            this.coursesService = coursesService;
            this.coursesService.GetUserCourses("user").ContinueWith((task) =>
            {
                List<GetCourseResponse>? courses = task.Result;
                if (courses is null)
                {
                    return;
                }
                foreach (var response in courses)
                {
                    ImageHelper.LoadFromWeb(new Uri(response.avatarUrl)).ContinueWith((task) =>
                    {
                        Courses.Add(new Course { Title = response.title, Progress = response.progressPercent, Image = task.Result });
                    });
                }
            });
            ImageHelper.LoadFromWeb(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCQ5CfcjmFVmEgOqDiXYT-to-veWt3hgBe_g&s")).ContinueWith((task) =>
            {
                Courses.Add(new Course { Title = "Курс 1", Progress = 10, Image = task.Result });
            });
        }
    }
}
