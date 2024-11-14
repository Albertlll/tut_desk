using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI;
using tutdesk.Models;
using tutdesk.Services;
using tutdesk.Services.Impl;

namespace tutdesk.ViewModels
{
    public partial class AuthViewModel : ViewModelBase
    {
        [ObservableProperty] private string errorMessage = "";
        [ObservableProperty] private string email = "";
        [ObservableProperty] private string password = "";

        private readonly ILoginService loginService;
        public AuthViewModel(DataService dataService) : base(dataService)
        {
            this.loginService = new LoginServiceImpl(new HttpClient());
        }

        // [RelayCommand]
        // private async Task Login()
        // {
        //     var authResult = await loginService.Authenticate(Email, Password);
        //     if(authResult is null)
        //     {
        //         ErrorMessage = "Неверная почта или пароль!";
        //         return;
        //     }
        //     ErrorMessage = "";

        //     CurrentUser currentUser = new CurrentUser();
        //     currentUser.Id = authResult.userId;
        //     currentUser.Email = authResult.email;
        //     UserService.SaveUser(currentUser);
        // }

        [RelayCommand]
        private async Task Login()
        {
            if(Email == "im" && Password == "imgey")
            {
                CurrentUser currentUser = new CurrentUser();
                currentUser.Id = "user1";
                currentUser.Email = Email;
                UserService.SaveUser(currentUser);
                return;
            }
            ErrorMessage = "Неверная почта или пароль!";
            return;
            /*var authResult = await loginService.Authenticate(Email, Password);
            if(authResult is null)
            {
                ErrorMessage = "Неверная почта или пароль!";
                return;
            }
            ErrorMessage = "";

            CurrentUser currentUser = new CurrentUser();
            currentUser.Id = authResult.userId;
            currentUser.Email = authResult.email;
            UserService.SaveUser(currentUser);*/
        }
        
    }
}
