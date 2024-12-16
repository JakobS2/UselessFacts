using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UselessFacts.Models;
using UselessFacts.Services;

namespace UselessFacts.ViewModel
{

    public partial class UselessFactVM : BaseViewModel
    {
        UselessFactService uselessFactService;

        [ObservableProperty]
        private UselessFact currentUselessFact = new();

        [ObservableProperty]
        private bool hasContent;

        [ObservableProperty]
        private string selectedLanguage = "en";

        public List<string> AvailableLanguages { get; } = new List<string> { "en", "de" };
        public UselessFactVM(UselessFactService uselessFactService)
        {
            Title = "Useless Fact";
            this.uselessFactService = uselessFactService;
        }

        [RelayCommand]
        async Task GetUselessFactAsync()
        {
            currentUselessFact = await uselessFactService.GetRandomUselessFact(selectedLanguage);
            HasContent = true;
            OnPropertyChanged(nameof(CurrentUselessFact));
        }

        [RelayCommand]
        async Task GetUselessDailyFactAsync()
        {
            currentUselessFact = await uselessFactService.GetDailyUselessFact(selectedLanguage);
            HasContent = true;
            OnPropertyChanged(nameof(CurrentUselessFact));
        }
    }
}
