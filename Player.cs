namespace TextAdventureCode
{
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
}