using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp2
{
    class RemoveAppliance
    {
        public static void RemoveApp()
        {
        Console.Clear();
        Lister.Lista();
        Console.WriteLine("Ange vilken köksapparat du vill ta bort.");
            int removeIndex = Convert.ToInt32(Console.ReadLine());
            removeIndex--;
            Console.WriteLine($"Din apparat {Lister.list1[removeIndex].Type} tas bort");
            Lister.list1.RemoveAt(removeIndex);
            Console.WriteLine("Tryck 0 för att gå tillbaka till huvudmenyn.");
            UserInput.UserInputs();
            UserChoice.UserChoise();

        }
    }
}
