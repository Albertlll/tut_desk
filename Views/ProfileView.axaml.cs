using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using tutdesk.Services.Impl;


namespace tutdesk.Views;

public partial class ProfileView : UserControl
{
    public ProfileView()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        UserService.DeleteUser();
        if(App.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop){
            desktop.Shutdown();
        }
    }
}