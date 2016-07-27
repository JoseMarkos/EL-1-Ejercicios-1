using System;
					
public class Program
{
	public static void Main()
	{
		int operation;

		Console.WriteLine("Ingrese num1: ");
		int num1 = Int32.Pare(Console.ReadLine());
		
		Console.WriteLine("Ingrese num2: ");
		int num2 = Int32.Pare(Console.ReadLine());
		
		Console.WriteLine("Ingrese num3: ");
		int num3 = Int32.Pare(Console.ReadLine());

		operation = num1 * num2 * num3;

		Console.Write("El resultado; " + operation);
	}
}
