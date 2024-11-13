using System;
using System.Collections.Generic;
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
        public LessonsViewModel(DataService service, string[] lessons) : base(service) {



        }
        
    }
}
