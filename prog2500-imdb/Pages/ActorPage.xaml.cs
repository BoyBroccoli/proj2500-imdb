using IMDB.Data;
using IMDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;
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
    /// Interaction logic for ActorPage.xaml
    /// </summary>
    public partial class ActorPage : Page
    {
        ImdbContext _context = new ImdbContext();
        CollectionViewSource ActorViewSource = new CollectionViewSource();

        public ActorPage()
        {
            InitializeComponent();

            // Link markup source to view source
            ActorViewSource = (CollectionViewSource)FindResource(nameof(ActorViewSource));

            // Load table from source
            _context.Names.Load();
            _context.Titles.Load();

            // Set View Source to use table
            ActorViewSource.Source = _context.Names.Local.ToObservableCollection();
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            ActorListView_Load(Search_Field.Text.ToLower());
        }

        private void ActorListView_Load(string Search_Term)
        {
            ActorListView.Items.Clear();

            IQueryable query;

            if(Search_Term is not null)
            {
                query =
                    from actor in _context.Names
                    where actor.PrimaryName.ToLower().Contains(Search_Term)
                    group actor by actor.PrimaryName.ToUpper().Substring(0, 1) into actor_group
                    select new
                    {
                        actor_index = actor_group.Key,
                        actor_count = actor_group.Count().ToString(),
                        actor = actor_group.ToList<Name>()
                    };
            }
            else
            {
                query =
                    from actor in _context.Names
                    group actor by actor.PrimaryName.ToUpper().Substring(0, 1) into actor_group
                    select new
                    {
                        actor_index = actor_group.Key,
                        actor_count = actor_group.Count().ToString(),
                        actor = actor_group.ToList<Name>()
                    };
            }            

            foreach(var actor in query)
            {
                ActorListView.Items.Add(actor);
            }
        }
    }
}
