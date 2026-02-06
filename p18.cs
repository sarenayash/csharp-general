using System;
class demo
{
	public static void Main()
    {
        Console.Write("Enter number of dimensions: ");
        int dim =Convert.ToInt32(Console.ReadLine());
        int [][][]arr = new int[dim][][];
        for (int i=0; i<dim; i++)
        {
            Console.Write("Enter number of rows [{0}]: ",i);
            int rows=Convert.ToInt32(Console.ReadLine());
            arr[i]=new int[rows][];
            for (int j=0; j<rows; j++)
            {
                Console.Write("Enter number of columns [{0}]:",j);
                int cols=Convert.ToInt32(Console.ReadLine());
                arr[i][j] = new int[cols];
                for (int k=0; k<cols; k++)
                {
                    Console.Write("Enter element [{0}]: ",k);
                    arr[i][j][k]=Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        Console.WriteLine("\nElements of 3D Jagged Array:");
        for (int i=0; i<arr.Length; i++)
        {
            Console.WriteLine("Dimension {[0]}:",i);
            for (int j=0; j<arr[i].Length; j++)
            {
                for (int k=0; k<arr[i][j].Length; k++)
                {
                    Console.Write(arr[i][j][k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
