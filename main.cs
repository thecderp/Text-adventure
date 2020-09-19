using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//The class for the player
public class Player {
  public string playerName;
  public int playerHealth;
  public int playerSpeed;
  public int playerStrength;
  //Yayy, my first time using classes.
  public static void SpawnPlayer() {
    Player mainPlayer = new Player();
    mainPlayer.playerName = "Hag";
    mainPlayer.playerHealth = 3;
    mainPlayer.playerSpeed = 2;
    mainPlayer.playerStrength = 2;
}

//The class for items
public class Item {
  public string itemName { get; set; }
  public string itemDescription { get; set; }
}

}
//This class here is the main one, and will stay. vvv
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Welcome to 'Text Adventure'");
    Player.SpawnPlayer();
    Item i = new Item();
  }
}
