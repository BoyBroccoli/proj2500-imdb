using Microsoft.EntityFrameworkCore;
using prog2500_imdb.Data;
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

       
        Page homePage;
        Page moviePage;
        Page actorPage;
        Page genrePage;
        public MainWindow()
        {
            InitializeComponent();

            homePage  = new Pages.HomePage();
            moviePage = new Pages.MoviePage();        
            actorPage = new Pages.ActorPage();
            genrePage = new Pages.GenrePage();
            mainFrame.NavigationService.Navigate(homePage);


        }


        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(homePage);
        }


        private void MoviesButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(moviePage);
        }

        private void ActorsButton_Click(object sender, RoutedEventArgs e)
        {
            //mainFrame.NavigationService.Navigate(actorPage);
        }

        private void GenresButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(genrePage);
        }
    }
}