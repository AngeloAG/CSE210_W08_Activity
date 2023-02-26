/*
Authors: 
  Jeffrey Meldrum
  Jeremiah Powell
	Angelo Arellano Gaona
	Alvaro Nunez
	Logan Clark

Date:

Description:
Responsibilities: Creates prompts to breath in and breath out.

Attributes:
 
Breath_In
Breath_Out
Behaviors:

Create strings that will be passed to activity which in turn displays the passed string
*/

using System;

public class SPAMBreathingActivity : SPAMActivity
{

  public SPAMBreathingActivity() : base("This activity will help you relax and lower your heartrate by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
  {

  }

  public void SPAMStartBreathingActivity()
  {
    // gets the desired duratin of the activity form the parent class
    int SPAMDuration = base.SpamInitializeActivity();

    // sets two datetime variables for the start and ending time.
    DateTime SPAMStartTime = DateTime.Now;
    DateTime SPAMFutureTime = SPAMStartTime.AddSeconds(SPAMDuration+10);
    DateTime SPAMCurrentTime = DateTime.Now;
    
    //allows the user to prepare for the activity
    Console.WriteLine("Beginning, get relaxed and wait for the prompt");
    Thread.Sleep(10000); 

    while (SPAMCurrentTime < SPAMFutureTime)
    {
      // breathes in then holds for 9 seconds
      Console.WriteLine("Breathe in through the nose and hold your breath.");
      Thread.Sleep(3000);
      // a loop that counts down how much time they have left to hold their breath
      for (int i = 9; i > 0; i --)
      {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
      }
      Console.WriteLine("Breathe out through the mouth.");
      Thread.Sleep(5000);
      SPAMCurrentTime = DateTime.Now;
      Console.Clear();
    }
    Console.WriteLine("Breathing activity finished.");
  }
}