using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektiIKlase
{
    class Program
    {
        static void Main(string[] args)
        {

            Zrakoplov x380 = new Zrakoplov();
            x380.setDosegleta(6000);
            x380.setNaziv("Airbus");
            x380.setSnagaMotora(2000);

            Zrakoplov PU123RO = new Zrakoplov("Cessna", 350, 125);

            Zrakoplov x328 = new Zrakoplov("Meanmachine", 5000);
            Console.WriteLine("Upisite doseg leta aviona: ");
            x328.setDosegleta(Convert.ToInt32(Console.ReadLine()));

            
            Console.WriteLine("naziv: " + x380.getNaziv() + ", doseg leta: " + x380.getDosegleta()+"km" + ", snaga motora: " + x380.getSnagaMotora()+"kW");
            
            Console.WriteLine(PU123RO.ToString());
            Console.WriteLine(x328.ToString());
            Console.ReadKey();

        }
    }
    
}
