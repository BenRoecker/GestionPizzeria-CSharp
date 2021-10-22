using System;
using System.Collections.Generic;
using System.Text;
using GestionPizzeria.Model;

namespace GestionPizzeria.Controller
{
    class CuisineController
    {
        private Model.Cuisine cuisine;
        private List<Client> clients;
        private List<Livreur> livreurs;

        public CuisineController(Cuisine _cuisine)
        {
            this.cuisine = _cuisine;
            clients = new List<Client>();
            livreurs = new List<Livreur>();
            livreurs.Add(new Livreur(0));
        }

        public void PayementCommis(Commis commis, float money)
        {
            commis.GetMoney(money);
            this.cuisine.Payement(money);
        }
        public void PayementLivreur(Livreur livreur, float money)
        {
            livreur.GetMoney(money);
            this.cuisine.Payement(money);
        }

        public void AddClient(Client client)
        {
            this.clients.Add(client);
        }

        public List<Client> GetClient()
        {
            return clients;
        }

        public Client existinclient(string id) 
        {
            foreach(Client client in clients)
            {
                if(client.GetName() == id)
                {
                    return client;
                }
            }
            return null;
        }

        public Livreur existinLivreur(int id)
        {
            foreach (Livreur livreur in livreurs)
            {
                if (livreur.GetId() == id)
                {
                    return livreur;
                }
            }
            return null;
        }
    }
}
