using CommunityToolkit.Mvvm.ComponentModel;
using tutdesk.Services.Impl;

namespace tutdesk.ViewModels;

public class ViewModelBase : ObservableObject
{
    public ViewModelBase(DataService service) { }
}
