using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
//Just Setting stuff up here
//This is the base code of the game, this may be edited or have a pull request or a copy, idk for now

  namespace BaseCode
  {
    public class Program
    {
      public static void Main(string[] args)
      {
        //I want to try to add a list for inventory vvv
        List<string> inventory = new List<string>(5);
        //Heres the "Hello there" message vvv
        Console.WriteLine("\nHey there\nWelcome to Text Adventure!");
        Console.Write("Type 'S' to start");
        Console.ReadLine();
        string pressPlay = Console.ReadLine();
        //This code here will be temporary vvv
        Console.WriteLine("Here's the stuff in your inventory:"); //Learn how to have a limit on the inventory pls(5 items)
        //This code will just put stuff in the iventory vvv
        inventory.add("Book");
        inventory.add("Hat");
        //Let's read that stuff
        for (int i = 0; i < 2; i++)
        {
          Console.WriteLine("inventory");
        }
        //This bit of code helps the terminal stay open when the code runs vvv
        Console.ReadKey();
      }
    }
  }
