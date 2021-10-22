using System;
using System.Collections.Generic;
using System.Text;
using GestionPizzeria.Model;

namespace GestionPizzeria.Controller
{
    class CuisineController
    {
        private Model.Cuisine cuisine;

        public CuisineController(Cuisine _cuisine)
        {
            this.cuisine = _cuisine;
        }

        public void PayementCommis(Commis commis, float money)
        {
            commis.GetMoney(money);
        }
        public void PayementLivreur(Livreur livreur, float money)
        {
            livreur.GetMoney(money);
        }
    }
}
