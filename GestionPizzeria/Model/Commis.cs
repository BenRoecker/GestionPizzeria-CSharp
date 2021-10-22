using System;
using System.Collections.Generic;
using System.Text;

namespace GestionPizzeria.Model
{
    class Commis
    {
        private string name;
        private string surname;
        private float money { get; set; }

        public Commis(string _name, string _surname)
        {
            this.name = _name;
            this.surname = _surname;
        }
        public void GetMoney(float money)
        {
            this.money += money;
        }

        public void receptionCommande(Commande commande)
        {
            commande.preparation();
        }

        //Ajout de fonction à définir
    }
}
