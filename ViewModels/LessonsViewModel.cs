using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI;
using tutdesk.Models;
using tutdesk.Services;
using tutdesk.Services.Impl;

namespace tutdesk.ViewModels
{
    public partial class LessonsViewModel : ViewModelBase
    {
        [ObservableProperty]
        public Module? selectedModule;
        
        public ObservableCollection<Lesson> Lessons { get;}  = new ObservableCollection<Lesson>();
        
        public LessonsViewModel(DataService service, Lesson[] lessons) : base(service) {


            Console.WriteLine(lessons);

             

            // if (service.SelectedModule.Lessons is null) return;

             foreach (Lesson item in lessons)
              {
                 Console.WriteLine(item);
                  Lessons.Add(item);
              }
            
        }
    }
}
