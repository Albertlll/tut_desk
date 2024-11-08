
using System;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using tutdesk.Helpers;

namespace tutdesk.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";

    [ObservableProperty]
    private ListItemTemplate? _selectedListItem;

     partial void OnSelectedListItemChanged(ListItemTemplate? value)
     {
     if (value is null) return;
         var instance = Activator.CreateInstance(value.ModelType);
         if (instance is null) return;
         CurrentPage = (ViewModelBase)instance;
     }


    [ObservableProperty]
    private ViewModelBase _currentPage = new HomeViewModel();

    public ObservableCollection<ListItemTemplate> Items { get; } = new()
    {
        // new ListItemTemplate(typeof(HomeViewModel), "house.png"),
        // new ListItemTemplate(typeof(SavedViewModel), "folder.png"),
        new ListItemTemplate(typeof(SavedViewModel), "avares://tutdesk/Assets/Icons/house.png"),
        new ListItemTemplate(typeof(HomeViewModel), "avares://tutdesk/Assets/Icons/folder.png"),
    };

}

public class ListItemTemplate {

    public ListItemTemplate(Type type, string icon) {
        ModelType = type;
        Label = type.Name;
        ListItemIcon  = ImageHelper.LoadFromResource(new Uri(icon));
;
    }

    // public string ListItemIcon { get; }
    public Bitmap? ListItemIcon { get; }
    public Type ModelType { get; }
    public string Label { get; }

    
    
}