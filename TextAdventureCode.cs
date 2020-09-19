using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//The class for the player
public class Player {
  public string playerName { get; set; }
  public int playerHealth { get; set; }
  public int playerSpeed { get; set; }
  public int playerStrength { get; set; }
  public Player(string name, int health, int speed, int strength) {
    this.playerName = name;
    this.playerHealth = health;
    this.playerSpeed = speed;
    this.playerStrength = strength;
  }
}

//The class for items
public class Item {
  public string itemName { get; set; }
  public string itemDescription { get; set; }
  //attempting to make an Item
}

public static void GameStartUp() {
  //Sword 
  new Item(){
    itemName = "Sword", 
    itemDescription = "Sharpy and hurty"};
}

//This class here is the main one, and will stay. vvv
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Welcome to 'Text Adventure'");

  }
}
