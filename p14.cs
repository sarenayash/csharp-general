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
        Console.WriteLine("\nEnter elements of the 2D array:");
        for (int i=0; i<r; i++)
        {
            for (int j=0; j<c; j++)
            {
                Console.Write("Element [{0},{1}]: ",i,j);
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\n2D Array in Tabular Format:");
        for (int i=0; i<r; i++)
        {
            for (int j=0; j<c; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n\n\nDuplicate Elements and Count:");
        bool f=false;
        for (int i=0; i<r; i++)
        {
            for (int j=0; j<c; j++)
            {
                int count=1;
                bool ac= false;
                for (int x=0; x<=i; x++)
                {
                    for (int y=0; y<c; y++)
                    {
                        if (x==i && y==j)
                            break;
                        if (arr[i,j]== arr[x, y])
                        {
                            ac= true;
                            break;
                        }
                    }
                    if (ac)
                        break;
                }

                if (ac)
                    continue;
                for (int x=i; x<r; x++)
                {
                    for (int y=0; y<c; y++)
                    {
                        if (x==i && y<=j)
                            continue;

                        if (arr[i,j]==arr[x,y])
                            count++;
                    }
                }
                if (count>1)
                {
                    Console.WriteLine("Element {arr[0],[1]} occurs {count} times",i,j);
                    f= true;
                }
            }
        }

        if (!f)
        {
            Console.WriteLine("No duplicate elements found.");
        }
    }
}
