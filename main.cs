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
        //I want to try to add a list for inventory
        List<string> inventory = new List<string>(5);
        //Heres the "Hello there" message
        Console.Write("█ █ █▀▀ █▄█   ▀█▀ █ █ █▀▀ █▀█ █▀▀\n█▀█ ██▄  █     █  █▀█ ██▄ █▀▄ ██▄ ");
        Console.ReadKey();
      }
    }
  }