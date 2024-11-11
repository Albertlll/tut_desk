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

namespace tutdesk.ViewModels
{
    public partial class AuthViewModel : ViewModelBase
    {
        [ObservableProperty] private string errorMessage = "";
        [ObservableProperty] private string email = "";
        [ObservableProperty] private string password = "";

        private readonly ILoginService loginService;
        public AuthViewModel(ILoginService loginService) 
        {
            this.loginService = loginService;
        }

        [RelayCommand]
        private async Task Login()
        {
            var authResult = await loginService.Authenticate(Email, Password);
            if(authResult is null)
            {
                ErrorMessage = "Неверная почта или пароль!";
                return;
            }
            ErrorMessage = "";
        }
        
    }
}
