/*
Authors: 
  Jeffrey Meldrum
  Jeremiah Powell
	Angelo Arellano Gaona
	Alvaro Nunez
	Logan Clark

Date:

Description:
Responsibilities: Create prompts to tell the user to think deeply or in a specific way.

Attributes:
_CreatePrompts

Behaviors:
creates specific prompts that are meant to encourage the user to reflect on certain things
*/

System.Random rnd = new System.Random();
public class SPAMReflectingActivity : SPAMActivity
{
  List<string> prompts = new List<string>()
  { 
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
  };

  List<string> prompts2 = new List<string>()
  {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
  };

  public SPAMReflectingActivity() : base("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life")
  {
    
  }

  public string random_prompts()
  {
    System.Random rnd = new System.Random();
    int random_index = rnd.Next(4);
    return prompts[random_index];
  }

  public string random_prompts2()
  {
    System.Random rnd = new System.Random();
    int random_index = rnd.Next(4);
    return prompts2[random_index];
  }

  public void startReflecting_activity()
  {
    Console.WriteLine("Welcome to the Reflecting Activity!");
    Console.Write("How long, in seconds, would you like your session to be?");
    int _userTime = base.SpamInitializeActivity();
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_userTime);
    bool _userTime = true
    while _userwhile

    Console.WriteLine(prompts);


    Console.WriteLine(prompts2);
  }
}