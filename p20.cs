using System;
class Hotel
{
    public static void Main(string[] args)
    {
        int bill=0;
        char order='Y';
        Console.WriteLine("Welcome to Hotel");
        do
        {
            Console.WriteLine("\n       MENU         ");
            Console.WriteLine("1. Idli      - Rs.30");
            Console.WriteLine("2. Dosa      - Rs.50");
            Console.WriteLine("3. Maggi     - Rs.40");
            Console.WriteLine("4. Manchurian- Rs.100");
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int price = 0;
            string item = "";
            switch (choice)
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
                    Console.WriteLine("Invalid choice ");
                    continue;
            }
			Console.WriteLine("Your Order is: "+item);
			Console.WriteLine("Your Order's Quantity is:"+quantity);
            int total=price*quantity;
            bill=bill+total;
            Console.WriteLine("Do you want to continue ordering? (Y/N): ");
            order=Console.ReadLine().ToUpper()[0];
        } 
		while(order=='Y');
        Console.WriteLine(" YOUR FINAL BILL IS ");
        Console.WriteLine("Total Amount: Rs. "+bill);
    }
}
