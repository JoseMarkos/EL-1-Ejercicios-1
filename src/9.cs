using System;

public class Program
{
	public static void Main()
	{
		int	promedio;

		Console.WriteLine("Ingrese primer numero: ");
		int num1 = Int32.Parse(Console.ReadLine ());
		Console.WriteLine("Ingrese segundo numero: ");
		int num2 = Int32.Parse(Console.ReadLine ());
		Console.WriteLine("Ingrese tercer numero: ");
		int num3 = Int32.Parse(Console.ReadLine ());
		Console.WriteLine("Ingrese cuarto numero: ");
		int num4 = Int32.Parse(Console.ReadLine ());
		
		promedio = (num1 + num2 + num3 + num4) / 4;
		Console.WriteLine("El promedio de " + num1 + " " + num2 + " " + num3 + " " + num4 + " es: " + promedio);   
	}
}
