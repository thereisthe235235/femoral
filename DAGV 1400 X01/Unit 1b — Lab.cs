
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("what is the tepature:");
		int temp = Convert.ToInt32(Console.ReadLine());
		if (temp > 30) 
      {
        Console.WriteLine("Stay hydrated and avoid staying in the sun for too long!");
    }
		if (temp < 30)
	 {
        Console.WriteLine("its all good, weather looking fine");
	}
    // reading the temp that is inputed, and then it determined what line to read out.//

		{
			Console.WriteLine("what grade did you get?:");
			int score = Convert.ToInt32(Console.ReadLine());
if (score >= 90)
{
  Console.WriteLine("A");
} 
else if(score >= 80)
{
  Console.WriteLine("B");
}
else if(score <= 79)
{
	Console.WriteLine("Asuming this is a grade you got in highschool, You fail! And thats all that matters so isnt the other letter grades unnecessary?");
}
		
		}
	}
}
// reading what score you put into the code. And then putting the reader into 3 diffrent camps based on the input. and writing the statment reltive to the score // 

