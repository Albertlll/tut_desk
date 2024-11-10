using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using tutdesk.Models;

namespace tutdesk.Views;

public partial class ModulesView : UserControl
{
    public ModulesView(Course course)
    {
        InitializeComponent();
        DataContext = course;
    }
}