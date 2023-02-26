/*
Authors: 
  Jeffrey Meldrum
  Jeremiah Powell
	Angelo Arellano Gaona
	Alvaro Nunez
	Logan Clark

Date:

Description:
Responsibilities: Store user inputs

Attributes:
_promptList
_storedInputList

Behaviors:
It creates a list of all the user inputs based on the Prophet
*/

public class SPAMListingActivity : SPAMActivity
{
  public SPAMListingActivity() : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
  {
  }
  private List<string> _SPAMPromptList = new List<string>
  {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
  };

  private List<string> _SPAMStoredInputList = new List<string> { };

  public string SPAMRandPrompt
  {
    get
    {
      var rand = new Random();
      int max = _SPAMPromptList.Count();
      int min = 0;

      return _SPAMPromptList[rand.Next(min, max)];
    }
  }

  public void _SPAMStartListingActivity()
  {
    Console.WriteLine("Welcome to the listing activity.");
    int _SPAMUserTime = base.SpamInitializeActivity();

    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_SPAMUserTime);

    bool _SPAMKeepAsking = true;
    Console.WriteLine($"{SPAMRandPrompt}");

    while (_SPAMKeepAsking)
    {

      Console.Write("");
      string _SPAMUserEntry = Console.ReadLine();

      _SPAMStoredInputList.Add(_SPAMUserEntry);

      DateTime currentTime = DateTime.Now;
      if (currentTime > futureTime)
      {
        _SPAMKeepAsking = false;
      }
    }
    Console.WriteLine($"You entered {_SPAMStoredInputList.Count} items!");
    base.SpamActivityFinishMessage();
  }
}