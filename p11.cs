using System;
class Program11
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int []arr=new int[n];
        int sum=0;
        for (int i=0; i<n; i++)
        {
            Console.Write("Enter element at index [{0}] ",i);
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Array elements with index:");
        for(int i=0; i<n; i++)
        {
            Console.WriteLine("Index [{0}]:{1}",i,arr[i]);
            sum += arr[i];
        }
        Console.WriteLine("\nSum of all elements:"+sum);
    }
}
