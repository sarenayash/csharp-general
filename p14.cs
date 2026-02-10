using System;

class Program14
{
    public static void Main(string[] args)
    {
        int r, c;
        Console.Write("Enter number of rows: ");
        r = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        c = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[r, c];
        bool[,] visited = new bool[r, c];

        Console.WriteLine("\nEnter elements of the 2D array:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write("Element [{0},{1}]: ", i, j);
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\n2D Array:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nDuplicate elements and their count:");
        for (int i=0; i<r; i++)
        {
            for (int j=0; j<c; j++)
            {
                if(visited[i,j])
                    continue;
                int count=1;
                visited[i,j]=true;
                for (int x=i; x<r; x++)
                {
                    for (int y=0; y<c; y++)
                    {
                        if(x==i && y<=j)
                            continue;
                        if(arr[i,j]==arr[x,y])
                        {
                            count++;
                            visited[x,y]=true;
                        }
                    }
                }
                if(count>1)
                    Console.WriteLine("Element {0} in program {1} times", arr[i, j], count);
            }
        }
    }
}
