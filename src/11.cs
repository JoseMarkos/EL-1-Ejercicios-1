using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Ingrese su edad: ");
		int edad = Int32.Parse(Console.ReadLine ());
		
		Console.WriteLine("Te ves mayor de " + edad );   
	}
}
