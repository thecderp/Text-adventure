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
