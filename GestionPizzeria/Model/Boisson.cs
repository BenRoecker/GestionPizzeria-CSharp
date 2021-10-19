using System;
using System.Collections.Generic;
using System.Text;

namespace GestionPizzeria.Model
{
    class Boisson
    {
        private string nom { get; set; }
        private float price { get; set; }

        public Boisson(string nom, float price)
        {
            this.nom = nom;
            this.price = price;
        }

        public float GetPrice()
        {
            return this.price;
        }

        public string GetNom()
        {
            return this.nom;
        }
    }
}
