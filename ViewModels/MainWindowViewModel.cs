using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using tutdesk.Helpers;
using tutdesk.Models;
using tutdesk.Services;

namespace tutdesk.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{


    private DataService? _dataService;



    public MainWindowViewModel(DataService service) : base(service) {
        SelectedCourse = service.SelectedCourse;
        _dataService = service;
        _dataService.PropertyChanged += DataService_PropertyChanged;

    }


    private void DataService_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(DataService.SelectedCourse))
        {
            // Здесь вы можете обновить любое другое свойство или выполнить действия,
            // которые должны произойти при изменении выбранного курса.


            SelectedCourse = _dataService.SelectedCourse;

            // OnPropertyChanged(nameof(SelectedCourse)); // Обновляем локальное свойство ViewModel
        }
    }


    // public ICommand SendDataCommand { get; }

    // public MainWindowViewModel() {
    //     SendDataCommand = new RelayCommand(() => secondViewModel.ReceiveData("Hello from First"));
    // }


    [ObservableProperty]
    public Course selectedCourse;


    [ObservableProperty]
    private ViewModelBase _currentPage;

    public ObservableCollection<ListItemTemplate> Pages { get; } = new()
    {
        // new ListItemTemplate(typeof(HomeViewModel), "house.png"),
        // new ListItemTemplate(typeof(SavedViewModel), "folder.png"),
        new ListItemTemplate(typeof(SavedViewModel), "Профиль"),
        new ListItemTemplate(typeof(CoursesViewModel), "Курсы"),
    };



    [ObservableProperty]
    private ListItemTemplate? _selectedListItem;

     partial void OnSelectedListItemChanged(ListItemTemplate? value)
     {
        if (value is null) return;
            var instance = Activator.CreateInstance(value.ModelType, args : _dataService);
            if (instance is null) return;         
            CurrentPage = (ViewModelBase)instance;
        }
}

public class ListItemTemplate {

    public ListItemTemplate(Type type, string label) {
        ModelType = type;
        Label = label;
;
    }

    // public string ListItemIcon { get; }
    public Type ModelType { get; }
    public string Label { get; }
    
}
