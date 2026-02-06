using System;

class Program13
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the number of rows: ");
        int r=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int c=Convert.ToInt32(Console.ReadLine());
        int [,]arr= new int[r,c];
        Console.WriteLine();
        for (int i=0; i<arr.GetLength(0); i++)
        {
            for (int j=0; j<arr.GetLength(1); j++)
            {
                Console.Write("Element at [{0},{1}]: ",i,j);
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine();
        for (int i=0; i<arr.GetLength(0); i++)
        {
            for (int j=0; j<arr.GetLength(1); j++)
            {
                Console.Write(arr[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }
}