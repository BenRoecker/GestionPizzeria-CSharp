using System;
using System.Collections.Generic;
using System.Text;

namespace GestionPizzeria.Model
{
    class Cuisine
    {
        private Adresse adresse;
        private float compteEnBanque;

        public Cuisine(Adresse adresse, float money)
        {
            this.adresse = adresse;
            this.compteEnBanque = money;
        }
    }
}
