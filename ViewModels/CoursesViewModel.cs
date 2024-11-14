using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using tutdesk.Helpers;
using tutdesk.Models;
using tutdesk.Services;
using tutdesk.Services.Impl;
using tutdesk.Services.Responses;

namespace tutdesk.ViewModels
{
    public partial class CoursesViewModel : ViewModelBase
    {
        public ObservableCollection<Course> Courses { get; } = new ObservableCollection<Course>();

        [ObservableProperty]
        private Course? selectedCourse;

        private DataService _dataService;
        private ICoursesService coursesService;
        private IModulesService modulesService;

        public CoursesViewModel(DataService service) : base(service)
        {
            _dataService = service;
            coursesService = new CoursesServiceImpl(new System.Net.Http.HttpClient());
            modulesService = new ModulesServiceImpl(new System.Net.Http.HttpClient());
            coursesService.GetUserCourses(UserService.LoadUser().Id).ContinueWith((task) =>
            {
                List<GetCourseResponse>? courses = task.Result;
                if (courses is null)
                {
                    return;
                }
                foreach (var response in courses)
                {
                    modulesService.GetCourseModules(response.courseId).ContinueWith((module) => 
                    {
                        List<GetCourseModuleResponse>? modulesResponse = module.Result;

                        if (modulesResponse is null)
                        {
                            return;
                        }

                        ObservableCollection<Module> modules = new ObservableCollection<Module>();
                        for(int i = 0; i < modulesResponse.Count; i++)
                        {
                            modules.Add( new Module {Id = modulesResponse[i].moduleId, Title = modulesResponse[i].title});
                        }
                    
                        ImageHelper.LoadFromWeb(new Uri(response.avatarUrl)).ContinueWith((task) =>
                        {
                            Courses.Add(new Course { Title = response.title, Progress = response.progressPercent, Image = task.Result, Modules = modules});
                        });
                    });
                }
            });
            /*ImageHelper.LoadFromWeb(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCQ5CfcjmFVmEgOqDiXYT-to-veWt3hgBe_g&s")).ContinueWith((task) =>
            {
                Courses.Add(new Course { Title = "Курс 1", Progress = 10, Image = task.Result });
            });
            ImageHelper.LoadFromWeb(new Uri("https://upload.wikimedia.org/wikipedia/commons/4/41/NewtonsPrincipia.jpg")).ContinueWith((task) => {
                Courses.Add(new Course { Title = "Курс 2", Image = task.Result, Progress = 50, Modules = [
                    new Module {Id = "1", Title = "Пончики"},
                    new Module { Id = "2", Title = "Покемончики"},
                    new Module { Id = "3", Title = "Чикичики"},

                    ]});
            });*/
        }

        partial void OnSelectedCourseChanged(Course? value)
        {
            _dataService.SelectedCourse = value;
        }

    }
}