using System;
class jagged
{
	public static void Main(string[] args)
	{
		int [][]jarray=new int[4][];
		jarray[0]=new int[5];
		jarray[1]=new int[3];
		jarray[2]=new int[2];
		jarray[3]=new int[1];
		jarray[0][0]=98;
		jarray[0][1]=88;
		jarray[0][2]=95;
		jarray[0][3]=42;
		jarray[0][4]=45;
		jarray[1][0]=88;
		jarray[1][1]=78;
		jarray[1][2]=68;
		jarray[2][0]=58;
		jarray[2][1]=98;
		jarray[3][0]=88;
		Console.WriteLine("length of jagged array:"+jarray.Length);
		Console.WriteLine("row size of jagged array:"+jarray.GetLength(0));
		Console.WriteLine("column size of jagged array [0]:"+jarray[0].Length);
		Console.WriteLine("column size of jagged array [1]:"+jarray[1].Length);
		Console.WriteLine("column size of jagged array [2]:"+jarray[2].Length);
		Console.WriteLine("column size of jagged array [3]:"+jarray[3].Length);
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