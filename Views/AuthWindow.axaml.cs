using System.Collections.Generic;
using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using tutdesk.Models;
using tutdesk.ViewModels;
using tutdesk.Views;
using tutdesk.Services;
using tutdesk.Services.Impl;

namespace tutdesk;

public partial class AuthWindow : Window
{
    public AuthWindow()
    {
        InitializeComponent();
        DataContext = new AuthViewModel(new LoginServiceImpl(new System.Net.Http.HttpClient()));
        if(UserService.LoadUser() != null) 
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}