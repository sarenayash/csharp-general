using System;
class Hotel
{
    public static void Main(string[] args)
    {
        int bill = 0;
        string order = "Y"; 
        int totalQuantity = 0;
        Console.WriteLine("Welcome to Hotel");
        do
        {
            Console.Clear(); 
            Console.WriteLine("Welcome to Hotel");
            Console.WriteLine("\n        MENU        ");
            Console.WriteLine("1.Idli       - Rs.30");
            Console.WriteLine("2.Dosa       - Rs.50");
            Console.WriteLine("3.Maggi      - Rs.40");
            Console.WriteLine("4.Manchurian - Rs.100");
            Console.Write("\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int price = 0;
            string item = "";

            switch(choice)
            {
                case 1:
                    item = "Idli";
                    price = 30;
                    break;
                case 2:
                    item = "Dosa";
                    price = 50;
                    break;
                case 3:
                    item = "Maggi";
                    price = 40;
                    break;
                case 4:
                    item = "Manchurian";
                    price = 100;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again...");
                    Console.ReadKey(); 
                    continue;
            }
            int itemTotal = price * quantity;
            bill += itemTotal;
            totalQuantity += quantity;
            Console.WriteLine("\nYour Order: " + item);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Item Total: Rs. " + itemTotal);
            Console.WriteLine("Current Bill: Rs. " + bill); 
            Console.Write("\nDo you want to continue ordering? (Y/N): ");
            order = Console.ReadLine();
        } while (order == "Y" || order == "y");  
        Console.Clear(); 
        Console.WriteLine("--- FINAL BILL ---");
        Console.WriteLine("Total Items ordered: " + totalQuantity);
        Console.WriteLine("Total Amount to Pay: Rs." + bill);
    }
}