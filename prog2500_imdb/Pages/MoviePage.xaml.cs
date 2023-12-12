using Microsoft.EntityFrameworkCore;
using prog2500_imdb.Data;
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

        }

        private void customerOrdersSearchBtn_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = moviesSearch.Text;

            if (searchTerm != null)
            {

                var query = from title in _context.Titles
                            where title.PrimaryTitle.ToLower().Contains(searchTerm.ToLower())
                            group title by title.PrimaryTitle.ToUpper().Substring(0, 1) into title_group
                            select new
                            {
                                title_index = title_group.Key,
                                title = title_group.ToList()
                            };
                moviesListView.ItemsSource = query.ToList();

            }


        }
    }
}
