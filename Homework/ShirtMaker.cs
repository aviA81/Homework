using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks {
    internal class ShirtMaker {
        static void Main(string[] args) {
            Shirt theShirt;
            foreach (Colors c in Enum.GetValues(typeof(Colors))) {
                foreach (Designs d in Enum.GetValues(typeof(Designs))) {
                    theShirt = new Shirt(c, d);
                    Console.WriteLine(theShirt);
                }
            }
        }
    }
}
