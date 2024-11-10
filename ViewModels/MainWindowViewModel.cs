﻿using ReactiveUI;
using System.Collections.ObjectModel;


using tutdesk.Views;


namespace tutdesk.ViewModels;
public class MainWindowViewModel : ReactiveObject
{
    private object _currentPage;
    private PageViewModel _selectedPage;

    public ObservableCollection<PageViewModel> Pages { get; } = new ObservableCollection<PageViewModel>();

    public object CurrentPage
    {
        get => _currentPage;
        set => this.RaiseAndSetIfChanged(ref _currentPage, value);
    }

    public PageViewModel SelectedPage
    {
        get => _selectedPage;
        set
        {
            this.RaiseAndSetIfChanged(ref _selectedPage, value);
            if (value != null)
            {
                CurrentPage = value.View; // Переход на выбранную страницу
            }
        }
    }

    public MainWindowViewModel()
    {
        // Инициализация страниц
        Pages.Add(new PageViewModel("Главная", new HomeView()));
        Pages.Add(new PageViewModel("Курсы", new SavedView()));
        // Pages.Add(new PageViewModel("Настройки", new SettingsView()));

        // Установка начальной страницы
        SelectedPage = Pages[0]; // Выбор первой страницы по умолчанию
    }
}

public class PageViewModel
{
    public string Title { get; }
    public object View { get; }

    public PageViewModel(string title, object view)
    {
        Title = title;
        View = view;
    }
}
