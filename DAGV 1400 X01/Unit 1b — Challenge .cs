using System;
					
public class Program
{
	public static void Main()
	{
Console.WriteLine("what is the tempature:");
int temp = Convert.ToInt32(Console.ReadLine());
if(temp >= 0 && temp <= 10)
		{
			Console.WriteLine("its pretty cold, you may wanna put on a jacket.");
		}
else if (temp >= 10 && temp <= 20){
	Console.WriteLine("its not gonna be that cold, get a long sleave shirt.");
}
else if(temp >= 20 && temp <= 30){
	Console.WriteLine("its not cold, wear whatever your confortable with!");
}
else if(temp >= 30 && temp <= 40){
	Console.WriteLine("i would put on somthing lighter, short sleave, shorts. ");
}
else if(temp >= 40 && temp <= 50){
	Console.WriteLine("its really really hot, i would stay inside");
}
else if(temp >= 50 && temp <= 60){
	Console.WriteLine("you are melting into the concreat");
}
else if(temp >= 60 && temp <= 70){
	Console.WriteLine("you have steped out on the serface of the sun");
}
else{
	Console.WriteLine("this is beyound what i can tell you");
}
		// this is more or less the same as last time, but with alot more "else if"s. and then adding alot of lil quips, i also used alot of %% so i can nerrow the leanse even more //
		
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
else if(score >= 70)
{
	Console.WriteLine("C");
}
else if(score >= 60)
{
Console.WriteLine("D");
}
else if(score <= 60)
{
Console.WriteLine("F");
}
		Console.WriteLine("whats your favorite subject:");
			string favsub =Console.ReadLine();
		switch (favsub)
		{
		case  "Math":
    Console.WriteLine("Math? really? math?!");
    break;
  case  "Sciance":
    Console.WriteLine("Sciance is fun, but broad. you could be a bit more spasific");
    break;
  case "History":
    Console.WriteLine("why?, its kinda a snooze fest.");
    break;
  case "ELA":
    Console.WriteLine("yea, of course. you speak english, how can you fail that.");
    break;
		}
	}
}
	//for this portion i was pretty diffcult working on the switches. I thought it was pretty diffuclt using switches with stings instead if intagers. its my first time using them so it was a bit of a learning curve.//
