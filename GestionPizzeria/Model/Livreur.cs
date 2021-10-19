using System;
using System.Collections.Generic;
using System.Text;

namespace GestionPizzeria.Model
{
    class Livreur
    {
        private int id { get; set; }
        private List<Commande> commandes { get; set; }

        public Livreur(int id)
        {
            this.id = id;
            this.commandes = new List<Commande>();
        }

        public void AjoutCommande(Commande commande)
        {
            this.commandes.Add(commande);
        }

        public void DeleteCommande(Commande commande)
        {
            this.commandes.Remove(commande);
        }
    }
}
