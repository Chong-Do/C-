
using System;

class Monster
{
    public string name;
    public int hp;

    public Monster(string monsterName, int monsterHP)
    {
        name = monsterName;
        hp = monsterHP;
    }

    public int TakeDamage(int damage)
    {
        hp = hp - damage;

        if (hp < 0)
        {
            hp = 0;
        }

        return hp;
    }
}

class Program
{
    static void Main()
    {
        Monster monster = new Monster("Goblin", 100);

        int damage = 110;

        int remainingHP = monster.TakeDamage(damage);

        Console.WriteLine("Tên quái vật: " + monster.name);
        Console.WriteLine("Sát thuơng: " + damage);
        Console.WriteLine("HP còn lại: " + remainingHP);

        if (remainingHP <= 0)
        {
            Console.WriteLine("Quái vật đã chết");
        }
        else
        {
            Console.WriteLine("Quái vật còn sống");
        }
    }
}
