using System;
using System.Collections.Generic;
using System.Text;
using GestionPizzeria.Model;

namespace GestionPizzeria.Controller
{
    class ClientController
    {
        private Client client;

        public ClientController(Client _client)
        {
            this.client = _client;
        }

        public void creationCommande(Commande commande)
        {
            client.ajoutCommande(commande);
        }

        public void payement(Livreur livreur, float money)
        {
            client.payment(money);
            livreur.GetMoney(money);
        }
    }
}
