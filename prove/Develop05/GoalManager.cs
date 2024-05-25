using System.Formats.Asn1;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Debugging
        _goals.Add(new SimpleGoal("Simple Goal", "This is a simple goal", 10));
        _goals.Add(new EternalGoal("Eternal Goal", "This is an eternal goal", 5));
        _goals.Add(new CheckListGoal("Checklist Goal", "This is a checklist goal", 5, 3, 10));

        int choice = 0;

        do
        {
            Console.Clear();
            DisplayMenu();
            choice = GetChoice();

            switch (choice)
            {
                case 0:
                    DisplayMenu();
                    break;
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    CombatMode();
                    break;
                case 7:
                    SaveExit();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 7);
    }

    // Menu Options ----------------------------------------------------
    private void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._shortName}");
        }
    }

    private void ListGoalDetails()
    {
        Console.Clear();
        Console.WriteLine("Goals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    private void CreateGoal()
    {
        // Create a new goal
        Console.Clear();
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Cancel");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CreateSimpleGoal();
                break;
            case 2:
                CreateEternalGoal();
                break;
            case 3:
                CreateChecklistGoal();
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private void RecordEvent()
    {
        // Record an event
        Console.Clear();
        Console.WriteLine("Goals:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? (Enter 0 to cancel) ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice == -1)
        {
            return;
        }
        else if (choice >= -0 && choice < _goals.Count)
        {
            _goals[choice].RecordEvent();
            _score += _goals[choice]._points;

            Console.WriteLine($"Congratulations! You have been awarded {_goals[choice]._points} points.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    private void SaveGoals()
    {
        // Save the goals
        Console.WriteLine("Select a file name to save the goals to:");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"Player Score: {_score}");

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        // Save the player score for combat mode implementation... not the best way to do this, I know
        using (StreamWriter writer = new StreamWriter("PlayerData.txt"))
        {
            writer.WriteLine(_score);
        }
    }

    private void LoadGoals()
    {
        // Load the goals
        Console.WriteLine("Select a file name to load the goals from:");
        string fileName = Console.ReadLine();

        // read the file. It's super messy but hey, it works
        using (StreamReader reader = new StreamReader(fileName))
        {
            _goals.Clear();

            // Read the player score - kinda hacky to do it this way but I like the little details if I can use them
            string scoreLine = reader.ReadLine();
            string[] scoreParts = scoreLine.Split(' ');
            _score = int.Parse(scoreParts[2]);


            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split('|');

                if (parts.Length > 0)
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);

                    if (parts.Length == 4)
                    {
                        _goals.Add(new SimpleGoal(name, description, points));
                    }
                    else if (parts.Length == 5)
                    {
                        _goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (parts.Length == 7)
                    {
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[4]);
                        int amountCompleted = int.Parse(parts[6]);

                        _goals.Add(new CheckListGoal(name, description, points, target, bonus));
                    }
                }
            }
        }
    }

    private void SaveExit()
    {
        // Exit without saving?
        Console.Write("Save before exiting? (y/n) ");
        string response = Console.ReadLine();

        if (response.ToLower() == "y")
        {
            SaveGoals();
        }

        Console.WriteLine();
        Console.WriteLine("Goodbye!");
    }

    // Create Goal Methods ---------------------------------------------
    private void CreateSimpleGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for completing the goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = new SimpleGoal(name, description, points);
        _goals.Add(goal);
    }

    private void CreateEternalGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for each completion: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = new EternalGoal(name, description, points);
        _goals.Add(goal);
    }

    private void CreateChecklistGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for each completion: ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("Enter how many times the goal must be completed: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Enter the bonus points for total completion: ");
        int bonus = int.Parse(Console.ReadLine());

        Goal goal = new CheckListGoal(name, description, points, target, bonus);
        _goals.Add(goal);
    }

    // Display Menu Methods --------------------------------------------
    private void DisplayMenu()
    {
        DisplayPlayerInfo();

        Console.WriteLine("Menu options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Record Success");
        Console.WriteLine("6. Combat Mode");
        Console.WriteLine("7. Exit");
    }

    private int GetChoice()
    {
        Console.Write("Enter your choice: ");
        return int.Parse(Console.ReadLine());
    }
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points\n");
    }

    // Combat Mode -----------------------------------------------------
    public void CombatMode()
    {
        // Combat mode
        CombatMode combatMode = new CombatMode();
        combatMode.Start();

        Console.WriteLine("Press any key to exit combat mode...");
        Console.ReadKey();


    }
}