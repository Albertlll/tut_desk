using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using tutdesk.Services.Impl;
using tutdesk.ViewModels;

namespace tutdesk.Views;

public partial class HomeView : UserControl
{
    public HomeView()
    {
        InitializeComponent();
        DataContext = new CoursesViewModel(new CoursesServiceImpl(new System.Net.Http.HttpClient()));
    }
}