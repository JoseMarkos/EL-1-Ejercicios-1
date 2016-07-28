using System;

public class Program
{
	public static void Main()
	{
	  int[] table = new int[10];
		int	tableLength = table.Length;
		
		Console.WriteLine("Ingrese numero: ");
		int num = Int32.Parse(Console.ReadLine ());
		
    for (int i=0; i < tableLength; i++)
    	{
        table[i] = i + 1;
        Console.WriteLine(num + " * " + table[i] + " = " + (num * table[i]));
    	}
	}
}
