// Courey Elliott
// Find a number position in an array

using System;

class MainClass
{
	public static int UserData
	{ get; set; }

	public static void Finder(int [] arr)
	{
		int number = 0;
	
		do {

			if (arr [number] == UserData)
			{
				break;
			}

			else if (number < arr.Length) 
			{
				number = number + 1;
			} 

			else
			{
				number = 100;
				break;
			}

		} while (number < arr.Length);

		if (number == arr.Length)
			Console.WriteLine ("No such number found.");
		else
		Console.WriteLine ("The position of your number in the array is {0}.", number);
	}

	public static void Main (string[] args)
	{
		int [] Array1 = new int[] {1,6,2,3,8,4,9,7,5,10};
		int [] Array2 = new int[] {1,1,1,1};
		int [] Array3 = new int[] {5};
		Array.Sort(Array1);
		Array.Sort (Array2);
		Array.Sort (Array3);

		Console.WriteLine ("Please enter number to find:");
		UserData = Convert.ToInt32(Console.ReadLine ());

		Finder (Array1);
		//Finder (Array2);
		//Finder (Array3);

		//tested each part to make sure they worked before putting them in my method
		//Console.WriteLine (UserData);
		//Console.WriteLine (Array1 [3]);
	}
}
