using System;
class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Enter number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        if (num>0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if(num<0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}
