using System;

public class Program
{
	public static void Main()
	{
		string[,] array = new string[5, 3];

		Console.WriteLine("Ingrese el numero: ");
		string num = Console.ReadLine();

		Console.WriteLine ("------------------");

		for (int i = 0; i < 5; i++)
		{
			for (int h = 0; h < 3; h++ )
			{
				
				if (i % 5 != 0 ^ i == 4) 
				{
					if (h == 0 ^ h == 2) 
					{
						array[i, h] = num;
					
					} else 
					{
						array[i, h] = " ";
					}
										
				} else {
					array[i, h] = num;
				}

				Console.Write(array[i, h]);
			}

			Console.WriteLine ();
		}
		
	}
}
