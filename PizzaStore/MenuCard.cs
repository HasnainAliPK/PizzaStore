using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class MenuCard
    {
        

        Pizza Margherita = new Pizza(1, "MARGHERITA", 69, "Tomat & Ost");
        Pizza Vesuvio = new Pizza(2, "VESUVIO", 75, "Tomat, Ost & Skinke");
        Pizza Capricciosa = new Pizza(3, "CAPRICCIOSA", 80, "Tomat, Ost, Skinke og Champignon");


        Drikkevare Sodavand = new Drikkevare(20, "Sodavand", 15, "Pepsi Max, Pepsi, Faxe Kondi, Coca Cola, Gazoz");
        Drikkevare Vand = new Drikkevare(21, "Vand", 10, "");

        public override string ToString()
        {
            String message = Margherita + "\n" + Vesuvio + "\n" + Capricciosa + "\n" + " " + "\n" + Sodavand + "\n" + Vand;
            return message;
        }
    }
}
