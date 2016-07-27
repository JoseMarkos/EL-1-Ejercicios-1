using System;

public class Program
{
	public static void Main()
	{
    int[] table = new int[10];
		int		tableLength = table.Length;

		Console.WriteLine("Ingrese numero: ");
		int num = Int32.Parse(Console.ReadLine ());
    
		Console.WriteLine(tableLength);

    for (int i=0; i <= tableLength; i++)
    {
			table[i] = i + 1;
			Console.WriteLine(i);
      Console.WriteLine(num + " * " + table[i] + " = " + (num * table[i]));
    }
	}
}
