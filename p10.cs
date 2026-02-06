using System;
class Program10
{
    static void Main()
    {
        Console.Write("Enter the number of elements:");
        int n =Convert.ToInt32(Console.ReadLine());
        int []arr= new int[n];
        for(int i=0; i<n; i++)
        {
            Console.Write("Enter element : ");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Array elements are:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i]+" ");
        }
    }
}
