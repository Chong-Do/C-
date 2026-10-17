
using System;
using System.Collections.Generic;

class Player
{
    public string name;
    public int hp;
    public int damage;

    public Player(string playerName, int playerHP, int playerDamage)
    {
        name = playerName;
        hp = playerHP;
        damage = playerDamage;
    }
}

class Monster
{
    public string name;
    public int hp;
    public int damage;

    public Monster(string monsterName, int monsterHP, int monsterDamage)
    {
        name = monsterName;
        hp = monsterHP;
        damage = monsterDamage;
    }
}

class Program
{
    static void Main()
    {
        List<Player> players = new List<Player>
        {
            new Player("Knight", 100, 25),
            new Player("Archer", 80, 30),
            new Player("Mage", 60, 40)
        };

        List<Monster> monsters = new List<Monster>
        {
            new Monster("Goblin", 50, 10),
            new Monster("Orc", 100, 20),
            new Monster("Dragon", 200, 35)
        };

        Console.WriteLine("- DANH SÁCH NHÂN VẬT");

        for (int i = 0; i < players.Count; i++)
        {
            Console.WriteLine(
                players[i].name
                + " | HP: " + players[i].hp
                + " | Damage: " + players[i].damage
            );
        }

        Console.WriteLine("\n- DANH SÁCH QUÁI VẬT");

        for (int i = 0; i < monsters.Count; i++)
        {
            Console.WriteLine(
                monsters[i].name
                + " | HP: " + monsters[i].hp
                + " | Damage: " + monsters[i].damage
            );
        }
    }
}
