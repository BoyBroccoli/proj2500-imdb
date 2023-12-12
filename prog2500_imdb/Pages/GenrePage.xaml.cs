using prog2500_imdb.Data;
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
using prog2500_imdb.Models;

namespace prog2500_imdb.Pages
{
    /// <summary>
    /// Interaction logic for GenrePage.xaml
    /// </summary>
    public partial class GenrePage : Page
    {
        //db and viewsource
        private ImdbContext context = new ImdbContext();
        private CollectionViewSource genreViewSource;
        public GenrePage()
        {
            InitializeComponent();

            //connect viewsource from xml to code and fill the listbox
            genreViewSource = (CollectionViewSource)FindResource(nameof(genreViewSource));
            genreListBox.ItemsSource = context.Genres.Include(g => g.Titles.Take(100)).ToList();
        }

        private void genreSearchButton_Click(object sender, RoutedEventArgs e)
        {
            //grab term from searchbox
            string searchText = genreSearchBox.Text.ToLower();

            ////create db query to grab genres 
            var query =
                from genre in context.Genres
                where genre.Name.ToLower().Contains(searchText)
                select genre;

            ////display genres to our listview
            genreListBox.ItemsSource = query.Include(g => g.Titles.Take(100)).ToList();

        }
    }
}
