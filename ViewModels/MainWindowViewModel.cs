using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using tutdesk.Models;
using tutdesk.Services.Impl;


namespace tutdesk.ViewModels;
public partial class MainWindowViewModel : ViewModelBase
{
    private DataService? _dataService;

    [ObservableProperty]
    public Course? selectedCourse;


    [ObservableProperty]
    public Module? selectedModule;

    partial void OnSelectedModuleChanged(Module? value)
    {
         Console.WriteLine("Module Selected");
        
         if (value is not null && value.Lessons is not null)
         {
             Console.WriteLine("Module Selectedvfdvdf");

             var instance = Activator.CreateInstance(typeof(LessonsViewModel), args: [_dataService, value.Lessons]) as ViewModelBase;
             Console.WriteLine("Inst created");


             if (instance is null) return;
             CurrentPage = instance;
         }
    }

    

    // private void OnSelectedModuleChanged() {

    //     Console.WriteLine("Module Selected");
        
    //     if (SelectedModule is not null && SelectedModule.Lessons is not null)
    //     {
    //         Console.WriteLine("Module Selectedvfdvdf");

    //         var instance = Activator.CreateInstance(typeof(LessonsViewModel), args: [_dataService, SelectedModule.Lessons]) as ViewModelBase;
    //         if (instance is null) return;
    //         CurrentPage = instance;
    //     }
    // }


    [ObservableProperty]
    private ViewModelBase _currentPage;

    public MainWindowViewModel(DataService service) : base(service)
    {
        SelectedCourse = service.SelectedCourse;
        SelectedModule = service.SelectedModule;

        
        _dataService = service;
        _dataService.PropertyChanged += DataService_PropertyChanged;

    }


    


    private void DataService_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(DataService.SelectedCourse))
        {
            SelectedCourse = _dataService?.SelectedCourse;
        }
    }

    public ObservableCollection<ListItemTemplate> Pages { get; } = new()
    {
        new ListItemTemplate(typeof(ProfileViewModel), "Профиль"),
        new ListItemTemplate(typeof(CoursesViewModel), "Курсы"),
    };


    [ObservableProperty]
    private ListItemTemplate? _selectedListItem;

    partial void OnSelectedListItemChanged(ListItemTemplate? value)
    {
        if (value is null) return;
        var instance = Activator.CreateInstance(value.ModelType, args: _dataService);
        if (instance is null) return;
        CurrentPage = (ViewModelBase)instance;
    }
}

public class ListItemTemplate
{
    public ListItemTemplate(Type type, string label)
    {
        ModelType = type;
        Label = label;
    }

    // public string ListItemIcon { get; }
    public Type ModelType { get; }
    public string Label { get; }
}
