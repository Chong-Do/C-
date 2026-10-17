using System;

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

class Player
{
    public string name;
    public int hp;
    public int maxHP;
    public int damage;
    public Player(string playerName, int playerHP, int playerDamage)
    {
        name = playerName;
        hp = playerHP;
        maxHP = playerHP;
        damage = playerDamage;
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

    public int Heal(int healAmount)
    {
        hp = hp + healAmount;

        if (hp > maxHP)
        {
            hp = maxHP;
        }
        return hp;
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player("Knight", 100, 25);
        Monster monster = new Monster("Goblin", 50, 10);

        Console.WriteLine(" THÔNG TIN NHÂN VẬT");
        Console.WriteLine(player.name + " | HP: " + player.hp
            + " | Damage: " + player.damage);

        Console.WriteLine(monster.name + " | HP: " + monster.hp
            + " | Damage: " + monster.damage);

        Console.WriteLine("\n- CHIẾN ĐẤU");
        Console.WriteLine(monster.name + " tấn công " + player.name);
        int playerHP = player.TakeDamage(monster.damage);
        Console.WriteLine("HP Knight còn lại: " + playerHP);
        int healAmount = 30;
        Console.WriteLine("\n- SAU KHI HỒI MÁU");
        Console.WriteLine("Hồi máu cho " + player.name + ": "
            + healAmount + " HP");

        playerHP = player.Heal(healAmount);
        Console.WriteLine("HP Knight sau khi hồi: " + playerHP);
    }
}
