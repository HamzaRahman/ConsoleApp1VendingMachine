using System;

namespace ConsoleApp1VendingMachine
{
    class Program
    {
        //Declaring this variable as a static so we may be able to see ammount entered in the machine all time
        //int to decimal
        static decimal pool = 0;
        static void Main(string[] args)
        { 
            VendingMachine VM = new VendingMachine();
            bool ProductMenu = true;
            while(ProductMenu)
            {
                Console.Clear();
                
                Console.WriteLine("Ammount Entered in Machine:{0}", pool);
                Console.WriteLine("Enter 1 To Show All Products");
                Console.WriteLine("Enter 2 To Add Money");
                Console.WriteLine("Enter 3 To Buy A Product");
                Console.WriteLine("Enter 4 To Show A Product's Info");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        VM.ShowAll();
                        Console.WriteLine("Press Enter To Continue");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter Money: 1, 5, 10, 20, 50, 100, 500, 1000");
                        int ammount = Convert.ToInt32(Console.ReadLine());
                        pool = VM.InsertMoney(ammount);
                        Console.WriteLine("Ammount in machine:{0}", pool);
                        Console.WriteLine("Press Enter To Continue");
                        Console.ReadLine();
                        break;
                    case 3:
                        VM.ShowAll();
                        Console.WriteLine("Enter Product ID");
                        string ID = Console.ReadLine();
                        pool = VM.Purchase(ID);
                        Console.WriteLine("Ammount in machine:{0}", pool);
                        Console.WriteLine("Press Enter To Continue");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter Product ID");
                        ID = Console.ReadLine();
                        VM.Examine(ID);
                        Console.WriteLine("Press Enter To Continue");
                        Console.ReadLine();
                        break;
                }
            }
            
        }
    }
}
