using System;
class Hotel
{
    public static void Main(string[] args)
    {
        int bill = 0;
        string order = "Y"; 
        Console.WriteLine("Welcome to Hotel");
        do
        {
            Console.WriteLine("\n       MENU       ");
            Console.WriteLine("1.Idli       - Rs.30");
            Console.WriteLine("2.Dosa       - Rs.50");
            Console.WriteLine("3.Maggi      - Rs.40");
            Console.WriteLine("4.Manchurian - Rs.100");
            Console.Write("Enter your choice: ");
            int choice=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int quantity=Convert.ToInt32(Console.ReadLine());
            int price=0;
            string item="";
            switch(choice)
            {
                case 1:
                    item="Idli";
                    price=30;
                    break;
                case 2:
                    item="Dosa";
                    price=50;
                    break;
                case 3:
                    item="Maggi";
                    price=40;
                    break;
                case 4:
                    item="Manchurian";
                    price=100;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    continue;
            }
            int total=price*quantity;
            bill=bill+total;
            Console.WriteLine("Your Order is: "+item);
            Console.WriteLine("Your Quantity is: "+quantity);
            Console.WriteLine("Item Total: Rs. "+total);
            Console.Write("Do you want to continue ordering? (Y/N): ");
            order = Console.ReadLine(); 
        } 
        while (order == "Y" || order == "y");  
        Console.WriteLine("\nYOUR FINAL BILL IS");
        Console.WriteLine("Total Amount: Rs. " + bill);
    }
}
