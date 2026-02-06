using System;
class demo
{
	public static void Main(string[] args)
	{
		int [,]a=new int[2,3];
		a[0,0]=61;
		a[0,1]=62;
		a[0,2]=63;
		a[1,0]=64;
		a[1,1]=65;
		a[1,2]=66;
		Console.WriteLine("total number of row size:="+a.GetLength(0));
		Console.WriteLine("total number of column size:="+a.GetLength(1));
		Console.WriteLine("total number of elements:="+a.Length);
		for(int i=0; i<a.GetLength(0); i++)
		{
			for(int j=0; j<a.GetLength(1); j++)
			{
				Console.WriteLine(a[i,j]);
			}
		}
		Console.ReadLine();
	}
}