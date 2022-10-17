using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp2
{
    public class Lister // Klassen ger oss initieringslistan och visar den
    {
        public static List<KitchenAppliance> list1 = new List<KitchenAppliance>
        {
        new KitchenAppliance {Type ="Brödrost",Brand = "Electrolux", IsFunctioning = true},
        new KitchenAppliance {Type = "AirFryer",Brand = "Samsung", IsFunctioning = true }
        };

    public static void Lista() //Den här metoden listar upp listan i ordning.
        {
            Console.Clear();
            int order = 1;

            foreach (var sak in list1)
            {
                Console.WriteLine($"{order}. Typ: {sak.Type} Märke: {sak.Brand} Fungerar: {sak.IsFunctioning}");
                order++;
            }

        }
    }
}
