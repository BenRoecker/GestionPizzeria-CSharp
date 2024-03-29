﻿using System;
using System.Collections.Generic;
using System.Text;
using GestionPizzeria.Model;
using System.Threading;
using System.Threading.Tasks;

namespace GestionPizzeria.Controller
{
    class LivreurController
    {
        private Model.Livreur livreur;

        public LivreurController(Livreur _livreur)
        {
            this.livreur = _livreur;
        }

        public async void EnvoiePayementToCuisine(Cuisine cuisine, float money)
        {
            await Task.Run(() => livreur.PayMoney(money));
            cuisine.GetMoney(money);
        }

        public void Livraison(Client client, Commande commande)
        {
            client.reception(commande);
        }

        public Livreur GetLivreur()
        {
            return livreur;
        }
    }
}
