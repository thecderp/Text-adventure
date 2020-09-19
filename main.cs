using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Player {
  string playerName = "Hag";
  int playerHealth = 3;
  int playerSpeed = 0;
  int playerStrength = 0;
  //Yayy, my first time using classes.
}

//This class here is the main one, and will stay. vvv
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    //This is just a test, this will be removed vvv
    Console.WriteLine("playerName = ");
    Console.WriteLine("playerHealth = ");
    Console.WriteLine("playerSpeed = ");
    Console.WriteLine("playerStrength = ");
    Console.ReadLine();
  }
}