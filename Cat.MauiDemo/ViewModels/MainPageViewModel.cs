﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Cat.MauiDemo.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        private string _result = string.Empty;
        public string Result { get => _result; set => SetProperty(ref _result, value); }

        private RelayCommand _clickMeCommand;

        public RelayCommand clickMeConmand => _clickMeCommand ??= new RelayCommand(() => { Result = "Hello World!"; });
    }
}