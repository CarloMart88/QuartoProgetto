using System;

class Player
{
  // we gonna create the basement of our player 
  private int health = 100;
  private int attackDamage = 20;
  private int healingCapacity = 15;
  private int maxHealth = 100;

  private void SpawnPlayer()
  {
    Console.WriteLine("\\n==================================================");
    Console.WriteLine(" 🍕 DOUGH MASTER: GUARDIAN OF THE GOLDEN CRUST 🍕 ");
    Console.WriteLine("==================================================\\n");
    Console.WriteLine("\\nDough Master: That scoundrel won't escape with my creation!\\n");
  }
}