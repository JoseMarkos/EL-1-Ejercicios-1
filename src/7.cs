using System;

public class Program
{
	public static void Main()
	{
		int sum;
		int subtraction;
		int multiplication;
		int divition;
		int mod;

		Console.WriteLine("Ingrese numero1: ");
		int num1 = Int32.Parse(Console.ReadLine ());

		Console.WriteLine("Ingrese numero2: ");
		int num2 = Int32.Parse(Console.ReadLine ());

		sum = num1 + num2;
		subtraction = num1 - num2;
		multiplication = num1 * num2;
		divition = num1 / num2;
		mod = num1 % num2;

		Console.WriteLine("Suma es: " + sum);
		Console.WriteLine("Resta es: " + subtraction);
		Console.WriteLine("Multipliacion es: " + multiplication);
		Console.WriteLine("Division es: " + divition);
		Console.WriteLine("Modulo es: " + mod);
	}
}
