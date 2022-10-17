// See https://aka.ms/new-console-template for more information
using KitchenApp2;

Start start = new Start();  //skapar objektet start kanske inte behövs.
Start.Welcome(); //Kör programmet


class Start
{
    public static int choise = 0;
   

    public static void Welcome()
    { 
    
       
        Console.WriteLine("========= Huvudmeny =========\n1. Använd köksapparat\n2. Lägg till köksapparat\n3. Lista köksapparater\n4. Ta bort köksapparat\n5. Avsluta");
        UserInput.UserInputs();//lagrar användarens input. Hämtar metod från klass
        UserChoice.UserChoise();// Behandlar användarens input. Hämtar metod från klass.

    }
}