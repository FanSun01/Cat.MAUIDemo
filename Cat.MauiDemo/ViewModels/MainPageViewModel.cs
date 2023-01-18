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

        public MainPageViewModel(IPoetryService poetryService)
        {
            _poetryService = poetryService;
        }

        public ObservableCollection<Poetry> Poetries { get; } = new();

        private RelayCommand _initializeCommand;

        public RelayCommand InitializeCommand => _initializeCommand ??= new RelayCommand(async () =>
        {
            await _poetryService.InitializeAsync();
        });

        private RelayCommand _addCommand;

        public RelayCommand AddCommand => _addCommand ??= new RelayCommand(() =>
        {
            var p = new Poetry()
            {
                Title = "Title",
                Content = "Content"
            };
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


    }
}
