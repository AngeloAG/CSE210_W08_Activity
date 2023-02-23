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
  protected SPAMActivity(int duration, String message)
  {
    _spamMessage = message;
    _spamDurationInSeconds = duration;
  }


  protected String SpamMessageToString()
  {
    return $"{_spamMessage}";
  }
}