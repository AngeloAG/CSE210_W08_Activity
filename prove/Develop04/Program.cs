/*
Authors: 
  Jeffrey Meldrum
  Jeremiah Powell
	Angelo Arellano Gaona
	Alvaro Nunez
	Logan Clark

Date:

Description:
Responsibilities:
To call menu and display the options given by it, and respond to the user selected option. Call the corresponding activity for the user 

Attributes:
Instances of eacb activity. and the menu

Behaviors:
It gets the menu options and display them. Captures user input and controls the activities being called.
*/
using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the mindfulness activities!");
    SPAMMenu spamMenu = new SPAMMenu();
    int spamBreathingActCount = 0;
    int spamReflectingActCount = 0;
    int spamListingActCount = 0;
    bool spamKeepRunning = true;
    do
    {
      Console.Clear();
      spamMenu.SPAMmenuSelection();
      SpamPrint($"");
      SpamPrint($"Completed Breathing Activities {spamBreathingActCount}");
      SpamPrint($"Completed Reflecting Activities {spamReflectingActCount}");
      SpamPrint($"Completed Listing Activities {spamListingActCount}");
      String spamUserChoice = spamMenu.SPAMselection();
      switch (spamUserChoice)
      {
        case "1":
          //Breathing activity
          spamBreathingActCount++;
          Console.Clear();
          SPAMBreathingActivity spamBreathingActivity = new SPAMBreathingActivity();
          spamBreathingActivity.SPAMStartBreathingActivity();
          break;
        case "2":
          // Reflecting Activity
          spamReflectingActCount++;
          Console.Clear();
          SPAMReflectingActivity spamReflectingActivity = new SPAMReflectingActivity();
          spamReflectingActivity.startReflecting_activity();
          break;
        case "3":
          // Listing Activity
          spamListingActCount++;
          Console.Clear();
          SPAMListingActivity spamListingActivity = new SPAMListingActivity();
          spamListingActivity._SPAMStartListingActivity();
          break;
        case "4":
          Console.Clear();
          SpamPrint("Thank you for using this program.");
          spamKeepRunning = false;
          break;
        default:
          SpamPrint("Invalid option. Please enter a valid option of the menu.");
          SpamReadConsole();
          break;
      }
    } while (spamKeepRunning);
    SpamCloseProgram();
  }

  static String SpamReadConsole()
  {
    return Console.ReadLine();
  }

  static void SpamPrint(String prompt)
  {
    Console.WriteLine(prompt);
  }

  static void SpamCloseProgram()
  {
    System.Environment.Exit(0);
  }
}