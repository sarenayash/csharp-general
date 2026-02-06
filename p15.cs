using System;

class program15
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of tables: ");
        int t = Convert.ToInt32(Console.ReadLine());
        int[,,] arr = new int[r, c, t];
        Console.WriteLine("\nEnter elements of the 3D array:");
        for (int k=0; k<t; k++)
        {
            Console.WriteLine("\nLayer [{0}]:",k);
            for (int i=0; i<r; i++)
            {
                for (int j=0; j<c; j++)
                {
                    Console.Write("Element [{0},{1},{2}]:",k,i,j);
                    arr[i,j,k]=Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        Console.WriteLine("\n3D Array in Tabular Format:");
        for (int k=0; k<t; k++)
        {
			Console.WriteLine("\nTABLE [{0}]:",k);
            for (int i=0; i<r; i++)
            {
                for (int j=0; j<c; j++)
                {
                    Console.Write(arr[i,j,k]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
