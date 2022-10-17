using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp2
{
    class RunningMachine
    {
        public static void Running()
        {
            Console.Clear();
            Lister.Lista();
            Console.WriteLine("Välj maskin att köra.");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            userChoice--;
            if (Lister.list1[userChoice].IsFunctioning == false)
            {
                Console.WriteLine($"Din apparat {Lister.list1[userChoice].Type} är tyvärr trasig.");
            }
            else
            {
                Console.WriteLine($"Din apparat {Lister.list1[userChoice].Type} körs.");
            }
            Console.WriteLine("Tryck 0 för att återgå till huvudmenyn.");
            UserInput.UserInputs();
            UserChoice.UserChoise();


        }

     
    }
}
