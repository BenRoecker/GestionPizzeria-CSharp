using System;
using System.Collections.Generic;
using System.Text;

namespace GestionPizzeria.Model
{
    class Client
    {
        private string name { get; set; }
        private string surname { get; set; }
        private string phone { get; set; }
        private DateTime firstCommand { get; set; }
        private Adresse adress { get; set; }
        private float money { get; set; }

        private List<Commande> commandes { get; set; }

        public Client(string name, string surname, string phone, Adresse adress)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.adress = adress;
            this.commandes = new List<Commande>();
        }

        public Client(string name, string username, string number)
        {
            this.name = name;
            this.surname = username;
            this.phone = number;
        }

        public void appeler()
        {

        }

        public void reception(Commande commande)
        {
            int index = this.commandes.LastIndexOf(commande);
            this.commandes[index].livré();
        }

        public void ajoutCommande(Commande commande)
        {
            this.commandes.Add(commande);
        }

        public void payment(float money)
        {
            if(money <= this.money)
            {
                this.money -= money;
            }
        }

        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }
    }
}
