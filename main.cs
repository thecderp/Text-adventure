using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Player {
  public string playerName;
  public int playerHealth;
  public int playerSpeed;
  public int playerStrength;
  //Yayy, my first time using classes.
  static void SpawnPlayer() {
    //code to execute
  }
}

public class Items {
  public string itemName;
  public string itemDescription;
  
}
//This class here is the main one, and will stay. vvv
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Hello World");
    Console.Write("What is your player's name?");
    Console.ReadLine();
  }
}
