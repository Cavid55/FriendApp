using System.Windows;
using FriendOrganization.UI.ViewModel;

namespace FriendOrganization.UI
{
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;
        public MainWindow(MainViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;
            DataContext = viewModel;
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
           await viewModel.LoadAsync();
        }
    }
}
