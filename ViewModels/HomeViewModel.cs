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
    public class HomeViewModel : ReactiveObject
    {
        public ObservableCollection<Course> Courses { get; } = new ObservableCollection<Course>();
        
        private readonly ICoursesService coursesService;
        public HomeViewModel(ICoursesService coursesService)
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
        }
    }
}
