using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using tutdesk.Models;

namespace tutdesk.Services.Impl
{
    public partial class DataService : ObservableObject
    {
        [ObservableProperty]
        private Course? selectedCourse;

        [ObservableProperty]
        public Module? selectedModule;

    }
}
