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
    /// Logique d'interaction pour Start_up.xaml
    /// </summary>
    public partial class Start_up : Page
    {
        public Start_up()
        {
            InitializeComponent();
        }

        private void Button_Click_Client(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Vue/VueClient.xaml", UriKind.Relative));
        }

        private void Button_Click_Livreur(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Vue/VueLivreur.xaml", UriKind.Relative));
        }
        private void Button_Click_Inscription(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Vue/Inscription.xaml", UriKind.Relative));
        }
        private void Button_Click_Admin(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Vue/Admin.xaml", UriKind.Relative));
        }
    }
}
