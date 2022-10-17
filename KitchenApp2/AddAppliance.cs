using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp2
{
    public class AddAppliance
    {
        
        public static void AddKitchenAppliance () //Constructorn för klassen
        {
            Console.Clear(); //Hämtar data från användaren.
            Console.WriteLine("Vilken typ av maskin är ditt köksredskap?");
            string aType = Console.ReadLine();
            Console.Clear(); 
            Console.WriteLine("Vilket märke har din maskin?");
            string aBrand = Console.ReadLine();
            Console.Clear(); 
            
        
            string YesNO = null;
            getYesNo(out YesNO);
            bool aIsFunctioning = YesNO =="j"; // Sätter YesNO till true om j. Allt annat ger false
            Console.WriteLine(YesNO);
            var kitchenappliance = new KitchenAppliance(); //Skapar objekt att läga till i listan
            kitchenappliance.Brand = aBrand;
            kitchenappliance.Type = aType; 
            kitchenappliance.IsFunctioning = aIsFunctioning;
            Lister.list1.Add(kitchenappliance);
            Console.Clear();
            Console.WriteLine($"Din maskin {kitchenappliance.Type} har lagts till i listan.");
            Console.WriteLine("Tryck 0 för att gå tillbaka till hudvudmenyn"); 
            UserInput.UserInputs();
            Console.Clear();
            
            

        }
        public static void getYesNo(out string yesno)
        {
            Console.WriteLine("Fungerar din maskin. Ja eller nej? (j/n)");
            yesno = Console.ReadLine();
            string local = yesno.ToLower();
            if (local.ToLower() == "j" || local.ToLower() == "n")
            {

            }
            else
            {
                getYesNo(out yesno); //outen tar en tillbaka, så det blir en automatisk parse
            }
          
        
        }
    }
}

