/*
Authors: 
  Jeffrey Meldrum
  Jeremiah Powell
	Angelo Arellano Gaona
	Alvaro Nunez
	Logan Clark

Date:

Description:
Responsibilities: stores class from the other defined activity

Attributes:
message prompt
amount of seconds(timer)

Behaviors:
stores child class data.
*/

public class SPAMActivity
{
  protected String _spamMessage;
  protected int _spamDurationInSeconds;
  protected SPAMActivity(String message)
  {
    _spamMessage = message;
  }


  protected int SpamInitializeActivity()
  {
    /*Sets the duration in seconds for the activity and returns it*/
    Console.WriteLine(_spamMessage);
    Console.Write("How Long, in seconds, would you like for your session? ");
    int spamDuration = int.Parse(Console.ReadLine());
    _spamDurationInSeconds = spamDuration;
    return spamDuration;
  }
}