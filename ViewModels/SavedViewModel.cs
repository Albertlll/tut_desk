using CommunityToolkit.Mvvm.ComponentModel;
using tutdesk.Services;

namespace tutdesk.ViewModels;

public partial class SavedViewModel : ViewModelBase
{
    public SavedViewModel(DataService service) : base(service)
    {
        
    }
}
