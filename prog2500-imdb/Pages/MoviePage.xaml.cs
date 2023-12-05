using IMDB.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes; 

namespace prog2500_imdb.Pages
{
    /// <summary>
    /// Interaction logic for MoviePage.xaml
    /// </summary>
    public partial class MoviePage : Page
    {

        ImdbContext _context = new ImdbContext();
        CollectionViewSource moviesViewSource; 

        public MoviePage()
        {
            InitializeComponent();

            moviesViewSource = (CollectionViewSource)FindResource(nameof(moviesViewSource));
            _context.Titles.Load();
            _context.Ratings.Load();

            _context.Names.Load();
            

        }

        private void customerOrdersSearchBtn_Click(object sender, RoutedEventArgs e)
        {



        }
    }
}
