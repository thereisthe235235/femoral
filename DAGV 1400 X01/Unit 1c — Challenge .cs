using System;

public class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        int one = rnd.Next(1, 11);
        Console.WriteLine(one);
        Console.WriteLine("A number between 1 though 10 has been created, guess what number it is. Im being kind today so you get 3 guesses");
        int guess = Convert.ToInt32(Console.ReadLine());

        int num = 2;
        while (num > 0)
        {
            if (guess == one)
            {
                Console.WriteLine("nice you got it");
                break;
            }
            else if (guess != one)
            {
                Console.WriteLine("nope try again");
                int wat = Convert.ToInt32(Console.ReadLine());
                guess = wat;
                num--;
            }
        }

    }
}
// i was having osme issues when i was trying to segment the code in difrrent directios i ended up sending. i just end up using if and then making them go over and over tell it was correct or they ran out of guesses.
// i dint havee time to do the other challage.