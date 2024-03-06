using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Pizza
    {
        int nummer;
        String pizza;
        String toppings;
        int pris;

        public Pizza(int nummer, string pizza, int pris, string toppings)
        {
            this.nummer = nummer;
            this.pizza = pizza;
            this.pris = pris;
            this.toppings = toppings;
        }

        public override string ToString()
        {
            String message = nummer + ". " + pizza + " - " + pris + ",-" + "\n" + toppings;
            return message;
        }
    }
}
