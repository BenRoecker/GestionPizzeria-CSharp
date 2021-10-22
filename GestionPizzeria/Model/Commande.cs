using System;
using System.Collections.Generic;
using System.Text;

namespace GestionPizzeria.Model
{
    class Commande
    {
        private int id;
        private DateTime date;
        private float price;
        private string etape;
        private List<Pizza> pizzas;
        private List<Boisson> boissons;

        public Commande(int id, DateTime date)
        {
            this.id = id;
            this.date = date;
            this.pizzas = new List<Pizza>();
            this.boissons = new List<Boisson>();
            this.price = 0.0F;
            this.etape = "init";
        }

        public void AjoutPizza(Pizza pizza)
        {
            this.pizzas.Add(pizza);
            this.price += pizza.GetPrice();
        }

        public void AjoutBoisson(Boisson boisson)
        {
            this.boissons.Add(boisson);
            this.price += boisson.GetPrice();
        }

        public void preparation()
        {
            this.etape = "preparation";
        }

        public void livré()
        {
            this.etape = "livré";
        }
    }
}
