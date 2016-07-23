using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Ingrese numero1: ");
		string num1 = Console.ReadLine();
		Console.WriteLine("Ingrese numero2: ");
		string num2 = Console.ReadLine();
		string num3 = num1;
		
		num1 = num2;
		num2 = num3;
		
		
		Console.WriteLine("Num1 es; " + num1);
		Console.WriteLine("Num2 es; " + num2);
	}
}
