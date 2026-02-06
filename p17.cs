using System;
class Program17
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int r=Convert.ToInt32(Console.ReadLine());
        int[][] jarray = new int[r][];
        for (int i=0; i<r; i++)
        {
            Console.Write("Enter size of row: ");
            int n = Convert.ToInt32(Console.ReadLine());
            jarray[i] = new int[n];
        }
        for (int i=0; i<jarray.Length; i++)
        {
            Console.WriteLine("Enter elements for row a[{0}]:",i);
            for (int j=0; j<jarray[i].Length; j++)
            {
                jarray[i][j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\nJagged Array Details:");
        Console.WriteLine("Number of rows: " + jarray.Length);
        for (int i=0; i< jarray.Length; i++)
        {
            Console.WriteLine("column size:"+jarray[i].Length);
        }
        Console.WriteLine("\nJagged Array Elements:");
        for (int i=0; i<jarray.Length; i++)
        {
            for (int j=0; j<jarray[i].Length; j++)
            {
                Console.Write(jarray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
