using System;
using System.Collections.Generic;
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

namespace GestionPizzeria.Vue
{
    /// <summary>
    /// Logique d'interaction pour VueLivreur.xaml
    /// </summary>
    public partial class VueLivreur : Page
    {
        public VueLivreur()
        {
            InitializeComponent();
        }
        private void TakeCommande(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Vue/Start_up.xaml", UriKind.Relative));
        }
    }
}
