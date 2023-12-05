using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prog2500_imdb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.NavigationService.Navigate(new Pages.HomePage());
        }

       
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.HomePage());
        }


        private void MoviesButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.MoviePage());
        }

        private void ActorsButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.ActorPage()); 
        }

        private void GenresButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.GenrePage()); 
        }
    }
}