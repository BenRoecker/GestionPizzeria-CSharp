using System;
using System.Collections.Generic;
using System.Text;

namespace GestionPizzeria.Model
{
    class Adresse
    {
        private int number{ get; set; }
        private string street { get; set; }
        private string town { get; set; }

        public Adresse(int number, string street, string town)
        {
            this.number = number;
            this.street = street;
            this.town = town.ToUpper();
        }

        public override string ToString()
        {
            return $"{ this.number} street {this.street} , {this.town}";
        }
    }
}
