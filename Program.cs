using System;

class Program
{
  static void Main()
  {
    string separator = "====================================================";
    string subSeparator = "----------------------------------------------------";

    // Introduzione narrativa
    Console.WriteLine(separator);
    Console.WriteLine("               🍕 MIDNIGHT PIZZA 🍕");
    Console.WriteLine(separator);
    Console.WriteLine("In a bustling pizzeria on a busy Friday night...");
    Console.WriteLine(subSeparator);
    Console.WriteLine("You, the Dough Master, created your magnum opus - \n the perfect pizza🤌 Suddenly, a sneaky Crust Bandit\n snatches your masterpieces!");
    Console.WriteLine(subSeparator);
    Console.WriteLine("Fueled by passion for your craft, you give chase...");
    Console.WriteLine(subSeparator);
    Console.WriteLine("Through winding alleys and crowded streets, you \n pursue the pizza pilferer. Finally, the Thief is\n cornered in a dead-end alley. It's time to recover \n your stolen slice!");
    Console.WriteLine(subSeparator);
    Console.WriteLine("                    🍕 FIGHT !🍕\n");

    // Spawn dei personaggi
    Player player = new Player();
    Enemy enemy = new Enemy();

    // Puoi aggiungere qui un loop di combattimento o interazioni
  }
}

class Player
{
  private int health = 100;
  private int attackDamage = 20;
  private int healingCapacity = 15;
  private int maxHealth = 100;

  public int Health
  {
    get => health;
    private set => health = Math.Clamp(value, 0, maxHealth);
  }

  public Player()
  {
    SpawnPlayer();
  }

  private void SpawnPlayer()
  {
    Console.WriteLine("\n==================================================");
    Console.WriteLine(" 🍕 DOUGH MASTER: GUARDIAN OF THE GOLDEN CRUST 🍕 ");
    Console.WriteLine("==================================================\n");
    Console.WriteLine("Dough Master: That scoundrel won't escape with my creation!\n");
  }
}

class Enemy
{
  private int health = 150;
  private int attackDamage = 10;
  private int maxHealth = 150;

  public int Health
  {
    get => health;
    private set => health = Math.Clamp(value, 0, maxHealth);
  }

  public Enemy()
  {
    SpawnEnemy();
  }

  private void SpawnEnemy()
  {
    Console.WriteLine("\n==================================================");
    Console.WriteLine(" 🦹 CRUST BANDIT: NEMESIS OF ITALIAN CUISINE 🦹 ");
    Console.WriteLine("==================================================\n");
    Console.WriteLine("Crust Bandit: You'll never catch me, flour face!\n");
  }
}