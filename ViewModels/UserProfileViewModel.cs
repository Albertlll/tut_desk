using System;
using CommunityToolkit.Mvvm.ComponentModel;
using tutdesk.Helpers;
using tutdesk.Models;
using tutdesk.Services;
using tutdesk.Services.Responses;

namespace tutdesk.ViewModels
{
    public partial class UserProfileViewModel : ViewModelBase
    {
        public UserProfile UserProfile { get; } = new UserProfile();

        private readonly IUserProfileService userProfileService;

        public UserProfileViewModel(IUserProfileService userProfileService)
        {
            this.userProfileService = userProfileService;
            GetProfileResponse? profileResponse = this.userProfileService.GetProfileInfo("user1").Result;

            if (profileResponse is null) 
            {
                return;
            }
            UserProfile.Email = profileResponse.email;
            UserProfile.FirstName = profileResponse.firstName;
            UserProfile.LastName = profileResponse.lastName;

            ImageHelper.LoadFromWeb(new Uri(profileResponse.avatarUri)).ContinueWith((task) =>
            {
                UserProfile.Avatar = task.Result;
            });
        }
    }
}
