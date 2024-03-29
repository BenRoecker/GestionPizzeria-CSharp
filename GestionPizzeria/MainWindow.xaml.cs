﻿using System;
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
using GestionPizzeria.Vue;
using GestionPizzeria.Controller;
using GestionPizzeria.Model;
using System.Globalization;

namespace GestionPizzeria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _NavigationFrame.Navigate(new Vue.Start_up());
            Application.Current.Properties.Add("Cuisine", new CuisineController(new Cuisine(null, 100F)));
            Application.Current.Properties.Add("Client", new ClientController(new Client(null, null, null)));
            List<Commande> commandes = new List<Commande>();
            commandes.Add(new Commande(0, DateTime.Now));
            Application.Current.Properties.Add("Commande", commandes);
            Application.Current.Properties.Add("Livreur", new LivreurController(new Livreur(0)));
        }
    }
}
