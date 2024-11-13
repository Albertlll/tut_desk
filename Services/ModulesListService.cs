



using System;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using tutdesk.Models;


namespace tutdesk.Services;
public partial class DataService : ObservableObject
{
        [ObservableProperty]
        private Course? selectedCourse;
}