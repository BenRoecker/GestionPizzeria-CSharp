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
    /// Logique d'interaction pour VueLivreur.xaml
    /// </summary>
    public partial class VueLivreur : Page
    {
        public VueLivreur()
        {
            InitializeComponent();
            List<Commande> Test = (List<Commande>)Application.Current.Properties["Commande"];
            foreach(Commande commande in Test)
            {
                if(commande.GetEtape() == "init")
                {
                    ListeCommandes.Items.Add(commande.ToString());
                } 
            }
        }
        private void TakeCommande(object sender, RoutedEventArgs e)
        {
            List<Commande> Test = (List<Commande>)Application.Current.Properties["Commande"];
            int id = ListeCommandes.SelectedIndex;
            LivreurController livreur = (LivreurController) Application.Current.Properties["Livreur"];
            livreur.GetLivreur().AjoutCommande(Test[id]);
            Test[id].livré();
            Application.Current.Properties["Commande"] = Test;

            this.NavigationService.Navigate(new Uri("Vue/Start_up.xaml", UriKind.Relative));
        }
    }
}
