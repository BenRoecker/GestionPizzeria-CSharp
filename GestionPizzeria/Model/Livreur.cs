using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GestionPizzeria.Model
{
    class Livreur
    {
        private int id { get; set; }
        private List<Commande> commandes { get; set; }
        private float money { get; set; }

        public Livreur(int id)
        {
            this.id = id;
            this.commandes = new List<Commande>();
            this.money = 0.0F;
        }

        public void AjoutCommande(Commande commande)
        {
            this.commandes.Add(commande);
        }

        public void DeleteCommande(Commande commande)
        {
            this.commandes.Remove(commande);
        }

        public void GetMoney(float money)
        {
            this.money += money;
        }

        public void PayMoney(float money)
        {
            if(this.money >= money)
            {
                Thread.Sleep(2000);
                this.money -= money;
            }
        }
    }
}
