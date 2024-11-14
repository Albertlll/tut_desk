using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using tutdesk.Models;
using tutdesk.Services;
using tutdesk.Services.Impl;

namespace tutdesk.ViewModels
{
    public partial class LessonsViewModel : ViewModelBase
    {
        // Property for selected module
        [ObservableProperty]
        private Module? selectedModule;

        // Collection of lessons
        public ObservableCollection<Lesson> Lessons { get; } = new ObservableCollection<Lesson>();

        // Commands for buttons
        public ICommand ContinueReadingCommand { get; }
        public ICommand CloseCourseCommand { get; }
        public ICommand MarkAsReadCommand { get; }

        // Constructor
        public LessonsViewModel(DataService service, Lesson[] lessons) : base(service)
        {
            // Initialize commands
            ContinueReadingCommand = new RelayCommand(OnContinueReading);
            CloseCourseCommand = new RelayCommand(OnCloseCourse);
            MarkAsReadCommand = new RelayCommand(OnMarkAsRead);

            // Populate lessons
            foreach (Lesson item in lessons)
            {
                Console.WriteLine(item);
                Lessons.Add(item);
            }
        }

        // Command methods
        private void OnContinueReading()
        {
            // Code to continue reading (e.g., navigate to the next lesson)
            Console.WriteLine("Continue Reading button clicked");
        }

        private void OnCloseCourse()
        {
            // Code to close the course (e.g., return to main menu)
            Console.WriteLine("Close Course button clicked");
        }

        private void OnMarkAsRead()
        {
            // Code to mark the current lesson as read
            Console.WriteLine("Mark as Read button clicked");
        }
    }
}
