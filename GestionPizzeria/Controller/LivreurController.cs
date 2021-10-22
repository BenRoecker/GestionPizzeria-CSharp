using System;
using System.Collections.Generic;
using System.Text;
using GestionPizzeria.Model;

namespace GestionPizzeria.Controller
{
    class LivreurController
    {
        private Model.Livreur livreur;

        public LivreurController(Livreur _livreur)
        {
            this.livreur = _livreur;
        }

        public void EnvoiePayementToCuisine(Cuisine cuisine, float money)
        {
            livreur.PayMoney(money);
            cuisine.GetMoney(money);
        }

        public void Livraison(Client client, Commande commande)
        {
            client.reception(commande);
        }
    }
}
