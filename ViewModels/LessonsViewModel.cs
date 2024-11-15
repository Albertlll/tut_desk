using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using ReactiveUI;
using tutdesk.Helpers;
using tutdesk.Models;
using tutdesk.Services;
using tutdesk.Services.Impl;
using tutdesk.Services.Responses;

namespace tutdesk.ViewModels
{
    public partial class LessonsViewModel : ViewModelBase
    {
        // Property for selected module
        [ObservableProperty]
        private Module? selectedModule;

        [ObservableProperty]
        private Lesson? selectedLesson;

        [ObservableProperty]
        private int nowLessonIndex = 0;


        // Collection of lessons

        public ObservableCollection<Lesson> Lessons { get; } = new ObservableCollection<Lesson> ();

        // Commands for buttons

        public ICommand ContinueReadingCommand { get; }
        public ICommand CloseCourseCommand { get; }
        public ICommand MarkAsReadCommand { get; }

        private DataService dataService;
        private readonly ILessonService lessonService;

        public LessonsViewModel(DataService service, Module module) : base(service)
        {
            ContinueReadingCommand = new RelayCommand(OnContinueReading);
            CloseCourseCommand = new RelayCommand(OnCloseCourse);
            MarkAsReadCommand = new RelayCommand(OnMarkAsRead);

            this.dataService = service;
            this.lessonService = new LessonServiceImpl(new HttpClient());
            lessonService.GetModuleLessons(module.Id).ContinueWith((response) =>
            {
                List<GetLessonResponse>? responseList = response.Result;
                if (response is null)
                {
                    return;
                }

                foreach (var lesson in responseList)
                {
                    List<LessonPart> parts = new List<LessonPart>();
                    foreach (var lessonPart in lesson.context)
                    {
                        string type;
                        string content;
                        lessonPart.TryGetValue("type", out type);
                        lessonPart.TryGetValue("content", out content);
                        if (type == "text")
                        {
                            parts.Add(new LessonPart { Text = content });
                        }
                        if (type == "image")
                        {
                            ImageHelper.LoadFromWeb(new Uri(content)).ContinueWith((task) =>
                            {
                                parts.Add(new LessonPart { Image = task.Result });
                            });
                        }
                    }

                    Lessons.Add(new Lesson { Id = lesson.lessonId, Title = lesson.title, Context = parts });
                }
                SelectedLesson = Lessons.First();
            });
            dataService.SelectedModule = module;
            dataService.SelectedModule.Lessons = Lessons;
        }

        private void OnContinueReading()
        {
            if(NowLessonIndex == Lessons.Count - 1)
            {
                NextEnabled = false;
                return;
            }
            NowLessonIndex += 1;
            SelectedLesson = Lessons[NowLessonIndex];
        }

        [ObservableProperty]
        private bool nextEnabled = true;

        private void OnNowLessonIndexChange(int value)
        {
            Console.WriteLine("value=" + value);
            if (value == Lessons.Count())
            {
                NextEnabled = false;
                return;
            }
            SelectedLesson = Lessons[value];

        }

        private void OnCloseCourse()
        {
 
        }

        private void OnMarkAsRead()
        {
            Console.WriteLine("Mark as Read button clicked");
        }
    }
}
