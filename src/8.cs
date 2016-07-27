using System;

public class Program
{
	public static void Main()
	{
    int[] table = new int[10];

		Console.WriteLine("Ingrese numero: ");
		int num = Int32.Parse(Console.ReadLine ());

    for (int i; i <= table.Lengdth; i++)
    {
      Console.WriteLine(num + "*" + table[i] + "=" + num * table[i]);
    }
	}
}
