using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp2
{
    public class KitchenAppliance : IKitchenAppliance //Ärver bara interfacet
    {


        public string Type { get; set; }
        public string Brand { get; set; }
        public bool IsFunctioning { get; set; }
        public void Use()
        {
            Console.WriteLine(IsFunctioning ? "Din masking körs." : "Din maskin körsinte ");
        }
        

    }
    


}

