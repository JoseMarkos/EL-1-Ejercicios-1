using System;
					
public class Program
{
	public static void Main()
	{
		double celsius, kelvin, fahrenheit;

		Console.WriteLine("Introduzca la cantidad de celsius: ");
		celsius = Convert.ToDouble(Console.ReadLine());

		fahrenheit = ((celsius * 9) / 5) + 32;
		kelvin = celsius + 273.15;

		Console.WriteLine("kelvin = " + kelvin);
		Console.WriteLine("fahrenheit = " + fahrenheit);
	}
}

