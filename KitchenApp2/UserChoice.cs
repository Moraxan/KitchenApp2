using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp2
{
    class UserChoice
    {
        public static void UserChoise()
        {
            switch (Start.choise)
            {
                case 1:
                    //kör klassen som använder apparat
                    Console.Clear();
                    RunningMachine.Running();
                    break;
                case 2:
                    AddAppliance.AddKitchenAppliance();
                    Start.Welcome();
                    break;
                case 3:
                    //Visa nuvarande lista
                    Console.WriteLine("Här är en lista på dina köksapparater:\n");
                    Lister.Lista();
                    Console.WriteLine("Tryck 0 för att komma tillbaka till huvudmenyn");
                    UserInput.UserInputs();
                    UserChoice.UserChoise();
                    break;
                case 4:
                    //kör klassen som tar bort en apparat från listan'
                    RemoveAppliance.RemoveApp();
                    break;
                case 5:
                    //avsluta programmet
                    Console.Clear();
                    Console.WriteLine("Avslutar programmet");
                    break;
                case 0:
                    Console.Clear();
                    Start.Welcome();
                    break;


                default:
                    Console.WriteLine("Ditt val finns inte i listan\nVar god gör ett nytt val");
                    UserInput.UserInputs();
                    break;
            }



        }
    }
}
