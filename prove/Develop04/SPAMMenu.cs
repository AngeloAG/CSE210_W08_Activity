/*
Authors: 
  Jeffrey Meldrum
  Jeremiah Powell
	Angelo Arellano Gaona
	Alvaro Nunez
	Logan Clark

Date: 2/23/22

Description:
Responsibilities: Return selected option

Attributes:
_Options
list of options

Behaviors:
Return user selected option
*/
using System;
public class SPAMMenu
{

  public SPAMMenu()
  {

  }

  public void SPAMmenuSelection()
  {
    Console.WriteLine("Welcome to the Mindfulness Program. Please choose and activity to continue.");
    Console.WriteLine("1). Breathing Activity");
    Console.WriteLine("2). Reflection Activity");
    Console.WriteLine("3). Listing Activity");
    Console.WriteLine("4). Quit");
  }


  public string SPAMselection()
  {
    Console.Write("Please enter the numberical value of the preferred activity: ");
    return Console.ReadLine();
  }
}