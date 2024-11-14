using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI;
using tutdesk.Helpers;
using tutdesk.Models;
using tutdesk.Services;
using tutdesk.Services.Impl;
using tutdesk.Services.Responses;

namespace tutdesk.ViewModels
{
    public partial class ProfileViewModel : ViewModelBase 
    {
        [ObservableProperty] 
        private UserProfile? userProfile;
        
        private readonly IUserProfileService userProfileService;
  
        public ProfileViewModel(DataService service) : base(service)
        {
            userProfileService = new UserProfileServiceImpl(new System.Net.Http.HttpClient());
            userProfileService.GetProfileInfo("user1").ContinueWith((response) =>
            {
                GetProfileResponse? getProfileResponse = response.Result;
                if (getProfileResponse is null)
                {
                    return;
                }
                ImageHelper.LoadFromWeb(new Uri(getProfileResponse.avatarUri)).ContinueWith((task) =>
                {
                    UserProfile = new UserProfile { Email = getProfileResponse.email, FirstName = getProfileResponse.firstName, LastName = getProfileResponse.lastName, Avatar = task.Result };

                });
            }
            );
        }

    }
}
