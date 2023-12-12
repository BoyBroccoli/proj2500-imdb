using Microsoft.EntityFrameworkCore;
using prog2500_imdb.Data;
using prog2500_imdb.Models;
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
        CollectionViewSource ActorViewSource;

        public ActorPage()
        {
            InitializeComponent();

            // Link markup source to view source
            ActorViewSource = (CollectionViewSource)FindResource(nameof(ActorViewSource));

            ActorListView_Load(null);
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            ActorListView_Load(Search_Field.Text.ToLower());
        }

        private void ActorListView_Load(string? Search_Term)
        {
            IQueryable query;

            // Clear the table first
            ActorListView.Items.Clear();

            // Load only if there is a search term
            if (Search_Term != null)
            {
                query =
                    from actor in _context.Names
                    where actor.PrimaryName.ToLower().Contains(Search_Term)
                    group actor by actor.PrimaryName.ToUpper().Substring(0, 1) into actor_group
                    select new
                    {
                        actor_index = actor_group.Key,
                        actor_count = actor_group.Count(),
                        actor = actor_group.ToList<Name>()
                    };

                foreach (var actor in query)
                {
                    ActorListView.Items.Add(actor);
                }
            }
        }
    }
}