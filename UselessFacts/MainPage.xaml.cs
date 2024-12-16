using UselessFacts.ViewModel;

namespace UselessFacts
{
    public partial class MainPage : ContentPage
    {
        public MainPage(UselessFactVM viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }

}
