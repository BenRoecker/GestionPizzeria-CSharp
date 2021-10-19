using System;
using System.Collections.Generic;
using System.Text;

namespace GestionPizzeria.Model
{
    class Pizza
    {
        private string taille;
        private string sauce;
        private List<string> topping;
        private float price;
        public Pizza(string taille, string sauce, List<String> topping, float price)
        {
            this.taille = taille;
            this.sauce = sauce;
            this.topping = topping;
            this.price = price;
        }

        public float GetPrice()
        {
            return this.price;
        }
    }
}
