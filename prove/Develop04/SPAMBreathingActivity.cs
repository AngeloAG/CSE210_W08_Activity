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
    DateTime SPAMFutureTime = SPAMStartTime.AddSeconds(SPAMDuration);
    DateTime SPAMCurrentTime = DateTime.Now;
    
    while (SPAMCurrentTime < SPAMFutureTime)
    {
      // breathes in then holds for 
      Console.WriteLine("Breathe in through the nose");
      Thread.Sleep(3000);
      Console.WriteLine("Hold");
      Console.WriteLine("");
      // a loop that counts down how much time they have left to hold their breath
      for (int i = 10; i > 0; i --)
      {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
      }
      Console.WriteLine("Breathe out through the mouth");
      Thread.Sleep(3000);
      SPAMCurrentTime = DateTime.Now;
    }
  }
}