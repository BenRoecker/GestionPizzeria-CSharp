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

namespace GestionPizzeria.Vue
{
    /// <summary>
    /// Logique d'interaction pour VueClient.xaml
    /// </summary>
    public partial class VueClient : Page
    {
        public VueClient()
        {
            InitializeComponent();
        }
        private void Button_Click_Client_Over(object sender, RoutedEventArgs e)
        {
            List<Commande> commandes = (List<Commande>) Application.Current.Properties["Commande"];
            Commande commande = new Commande(commandes.Count, DateTime.Now);
            Client client = (Client)Application.Current.Properties["Client"];
            List<string> topping = new List<string>(); // ajout superflu
            if (Normande.IsChecked == true && NormandeNumber.SelectedIndex != 1)
            {
                Pizza normande = new Pizza("moyenne", "tomate",topping, 5F);
                for(int i = 0; i < NormandeNumber.SelectedIndex -1; i++)
                {
                    commande.AjoutPizza(normande);
                }
            }
            if (ChevreMiel.IsChecked == true && ChevreMielNumber.SelectedIndex != 1)
            {
                Pizza chevremiel = new Pizza("moyenne", "tomate",topping, 4.5F);
                for (int i = 0; i < ChevreMielNumber.SelectedIndex - 1; i++)
                {
                    commande.AjoutPizza(chevremiel);
                }
            }
            if (Chorizo.IsChecked == true && ChorizoNumber.SelectedIndex != 1)
            {
                Pizza chorizo = new Pizza("moyenne", "tomate",topping, 4.5F);
                for (int i = 0; i < ChorizoNumber.SelectedIndex - 1; i++)
                {
                    commande.AjoutPizza(chorizo);
                }
            }
            if (Raclette.IsChecked == true && RacletteNumber.SelectedIndex != 1)
            {
                Pizza raclette = new Pizza("moyenne", "tomate",topping, 4.5F);
                for (int i = 0; i < RacletteNumber.SelectedIndex - 1; i++)
                {
                    commande.AjoutPizza(raclette);
                }
            }
            if (Coca.IsChecked == true && CocaNumber.SelectedIndex != 1)
            {
                Boisson coca = new Boisson("Coca", 3F);
                for (int i = 0; i < CocaNumber.SelectedIndex - 1; i++)
                {
                    commande.AjoutBoisson(coca);
                }
            }
            if (Fanta.IsChecked == true && FantaNumber.SelectedIndex != 1)
            {
                Boisson fanta = new Boisson("Fanta", 3F);
                for (int i = 0; i < FantaNumber.SelectedIndex - 1; i++)
                {
                    commande.AjoutBoisson(fanta);
                }
            }
            if (Oasis.IsChecked == true && OasisNumber.SelectedIndex != 1)
            {
                Boisson oasis = new Boisson("Oasis", 3F);
                for (int i = 0; i < OasisNumber.SelectedIndex - 1; i++)
                {
                    commande.AjoutBoisson(oasis);
                }
            }
            if (Perrier.IsChecked == true && PerrierNumber.SelectedIndex != 1)
            {
                Boisson perrier = new Boisson("Perrier", 3F);
                for (int i = 0; i < FantaNumber.SelectedIndex - 1; i++)
                {
                    commande.AjoutBoisson(perrier);
                }
            }
            client.ajoutCommande(commande);
            commandes.Add(commande);
            Application.Current.Properties["Commande"] = commandes;
            MessageBox.Show("Commande enregistrée");
            this.NavigationService.Navigate(new Uri("Vue/VueClientOver.xaml", UriKind.Relative));
        }
    }
}
