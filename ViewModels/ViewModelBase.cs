using CommunityToolkit.Mvvm.ComponentModel;
using tutdesk.Services;

namespace tutdesk.ViewModels;

public class ViewModelBase : ObservableObject
{
    public ViewModelBase(DataService service) {}
}
