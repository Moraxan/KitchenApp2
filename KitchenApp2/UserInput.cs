using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp2
{
    class UserInput
    {
        public static void UserInputs() //Metoden hämtar input från användaren och sparar i en övergripande variabel.
        {
            int achoise = 0;
            try
            {
                achoise = Convert.ToInt32(Console.ReadLine()); //Prövar om input är en int

            }
            catch (Exception)
            {

                Console.WriteLine("Ditt val är inte giltigt.\nFörsök igen:"); //Meddelar användaren vad som gick fel
                UserInputs(); //Användaren får försöka igen

            }

            Start.choise = achoise;


        }
    }
}
