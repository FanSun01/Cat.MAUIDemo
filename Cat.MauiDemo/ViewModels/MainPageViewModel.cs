using System.Collections.ObjectModel;
using System.Linq;
using Cat.MauiDemo.Models;
using Cat.MauiDemo.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Cat.MauiDemo.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        private IPoetryService _poetryService;
        private ITokenService _tokenService;

        public MainPageViewModel(IPoetryService poetryService, ITokenService tokenService)
        {
            _poetryService = poetryService;
            _tokenService = tokenService;
        }

        public ObservableCollection<Poetry> Poetries { get; } = new();

        private RelayCommand _initializeCommand;

        public RelayCommand InitializeCommand => _initializeCommand ??= new RelayCommand(async () =>
        {
            await _poetryService.InitializeAsync();
        });

        private RelayCommand _addCommand;

        public RelayCommand AddCommand => _addCommand ??= new RelayCommand(async () =>
        {
            var p = new Poetry()
            {
                Title = "Title",
                Content = "Content"
            };
            await _poetryService.AddAsync(p);
        });

        private RelayCommand _listCommand;

        public RelayCommand ListCommand => _listCommand ??= new RelayCommand(async () =>
        {
            var res = await _poetryService.GetPoetryListAsync();

            foreach (var poetry in res)
            {
                if (!Poetries.Contains(poetry))
                {
                    Poetries.Add(poetry);
                }
            }
        });


        private string _jsonToken;

        public string JsonToken
        {
            get => _jsonToken;
            set => SetProperty(ref _jsonToken, value);
        }

        private RelayCommand _loadJsonCommand;

        public RelayCommand LoadJsonCommand => _loadJsonCommand ??= new RelayCommand(async () =>
        {
            var res = await _tokenService.GetTokenAsync();
            JsonToken = res;
        });

    }
}
