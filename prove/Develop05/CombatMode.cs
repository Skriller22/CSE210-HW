// Author: Matthew Remington

// An extra feature for the Eternal Goal Program aka ETERNAL QUEST

//________________________________________________________________________________________\\

// Combat Mode -----------------------------------------------------
public class CombatMode
{
    public void Start()
    {
        // Initialize system
        Animations animations = new Animations();
        Player _player;

        // Initialize player
        Console.WriteLine("Entering Combat Mode...");
        animations.DotDotDot();

        Console.Clear();
        Console.WriteLine("Please enter your name: ");
        Console.Write("> "); string name = Console.ReadLine();
        _player = new Player(name);

        // Load player score and health
        _player.Points = CapturePlayerScore();
        _player.Health = _player.Points * 5;

        // Display player info
        Console.Clear();
        Console.WriteLine("Welcome, " + _player.Name + "!");
        Console.WriteLine("Your current score is: " + _player.Points);

        // Display starting message
        Console.WriteLine();
        Console.WriteLine("Welcome to the Arena!");
        Console.WriteLine("You will be fighting a series of monsters.");
        Console.WriteLine("You may use your points to aid you in battle.");
        Console.WriteLine("Good luck!");

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        Console.Clear();

        // Combat loop
        while(_player.Health > 0)
        {
            // Create monster
            Monster monster = new Monster(_player.Points / 10);

            // Display player info
            _player.DisplayPlayerInfo();

            // Fight monster
            FightMonster(_player, monster);
        }
    }

    private int CapturePlayerScore()
    {
        using (var reader = new StreamReader("PlayerData.txt"))
        {
            return int.Parse(reader.ReadLine());
        }
    }

    private void FightMonster(Player _player, Monster monster)
    {
        while(_player.Health > 0)
        {
            monster.DisplayMonsterInfo();
            _player.DisplayPlayerInfo();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            Console.WriteLine("3. Run");
            Console.Write("> "); string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        
        }
    }
}

// Player Class -----------------------------------------------------
public class Player
{
    public string Name { get; set; }
    public int Points { get; set; }
    public int Health { get; set; }

    public Player(string name)
    {
        Name = name;
        Points = 0;
        Health = Points * 5;
    }

    public void DisplayPlayerInfo()
    {
        Console.Clear();
        Console.WriteLine("Player: " + Name);
        Console.WriteLine("Points: " + Points);
        Console.WriteLine("Health: " + Health);
        Console.WriteLine();
    }
}

public class Monster
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    private static Random random = new Random();
    private static List<string> names = new List<string> { 
        "Dragon", "Goblin", "Troll", "Ogre", "Ghoul",
        "Skeleton", "Zombie", "Wraith", "Vampire", "Werewolf",
        "Mummy", "Banshee", "Spectre", "Lich", "Hydra"};

    public Monster(int difficulty)
    {
        Name = names[random.Next(names.Count)];
        Health = random.Next(difficulty * 10, difficulty * 20);
        Damage = random.Next(difficulty * 1, difficulty * 5);
    }

    public void DisplayMonsterInfo()
    {
        Console.WriteLine(Name + ":");
        Console.WriteLine("Health: " + Health);
        Console.WriteLine("Damage: " + Damage);
    }
}

// Animations Class ------------------------------------------------
public class Animations
{
    public void DotDotDot()
    {
        Console.WriteLine();
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
    }

    public void Pause()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void SwordSlash()
    {
        Console.WriteLine("Sword Slash!");
    }

    public void Fireball()
    {
        Console.WriteLine("Fireball!");
    }

    public void Heal()
    {
        Console.WriteLine("Heal!");
    }
}