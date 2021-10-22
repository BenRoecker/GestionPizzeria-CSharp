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
using GestionPizzeria.Model;
using GestionPizzeria.Controller;

namespace GestionPizzeria.Vue
{
    /// <summary>
    /// Logique d'interaction pour Inscription.xaml
    /// </summary>
    public partial class Inscription : Page
    {

  
        public Inscription()
        {
            InitializeComponent();

        }

        public string PlaceholderText { get; set; }
        private void ComeBack(object sender, RoutedEventArgs e)
        {
            Client client = new Client(name.Text, surname.Text, phoneNumber.Text);
            MessageBox.Show("Nom du client crée :"+ client.GetName() + "\nSon prénom :" + client.GetSurname() + "\n" + Application.Current.Properties["Cuisine"].GetType());
            CuisineController cuisine = (CuisineController) Application.Current.Properties["Cuisine"];
            cuisine.AddClient(client);
            Application.Current.Properties["Cuisine"] = cuisine;
            this.NavigationService.Navigate(new Uri("Vue/Start_up.xaml", UriKind.Relative));

            
        }
    }
}
