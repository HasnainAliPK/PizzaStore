using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Drikkevare
    {
        int nummer;
        String drikkevare;
        String type;
        int pris;
        public Drikkevare(int nummer, string drikkevare, int pris, string type)
        {
            this.nummer = nummer;
            this.drikkevare = drikkevare;
            this.pris = pris;
            this.type = type;
        }
        
        public override string ToString()
        {
            String message = nummer + ". " + drikkevare + " " + pris + ",-" + "\n" + type;
            return message;
        }
    }
}
