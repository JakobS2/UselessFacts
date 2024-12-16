using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Specialized;

namespace UselessFacts.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        public BaseViewModel()
        {
        }

        [ObservableProperty]
        string title;
    }
}