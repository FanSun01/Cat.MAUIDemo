using Cat.MauiDemo.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Cat.MauiDemo.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        private string _result = string.Empty;
        public string Result { get => _result; set => SetProperty(ref _result, value); }

        private readonly IKeyValueStorage _keyValueStorage;

        private RelayCommand _readCommand;

        public MainPageViewModel(IKeyValueStorage keyValueStorage)
        {
            _keyValueStorage = keyValueStorage;
        }

        public RelayCommand ReadCommand => _readCommand ??= new RelayCommand(() =>
        {
            Result = _keyValueStorage.Get("key", string.Empty);
        });

        private RelayCommand _writeCommand;

        public RelayCommand WriteCommand => _writeCommand ??= new RelayCommand(() =>
        {
            _keyValueStorage.Set("key", Result);
        });


    }
}
