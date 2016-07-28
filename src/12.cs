using System;

public class Program
{
	public static void Main()
	{
		string[,] array = new string[4, 4];
	
		Console.WriteLine("Ingrese el numero: ");
		string num = Console.ReadLine();

		Console.WriteLine ("------------------");

		for (int i = 0; i < 4; i++ )
		{
			for (int h = 0; h < 4; h++ )
			{
				
				if (i % 2 == 0) 
				{
					if (h == 0) 
					{
						array [i, h] = num;
					
					} else 
					{
						array[i, h] = " " + num;
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
