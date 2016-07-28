using System;

public class Program
{
	public static void Main()
	{
		string des2 = " y x + x . y . z es ";
		int op1;
		int op2;

		Console.WriteLine("Ingrese primer numero: ");
		int num1 = Int32.Parse(Console.ReadLine ());
		Console.WriteLine("Ingrese segundo numero: ");
		int num2 = Int32.Parse(Console.ReadLine ());
		Console.WriteLine("Ingrese tercer numero: ");
		int num3 = Int32.Parse(Console.ReadLine ());
		
		op1 = (num1 + num2) * num3;
		op2 = num1 + num1 * num2 * num3;

		string des1 = "Resultado de numeros especificados " + num1 + " " + num2 + " y " + num3 + " " + ", (x + y) . z es ";
		Console.WriteLine(des1 + op1 + des2 + op2);   
	}
}
