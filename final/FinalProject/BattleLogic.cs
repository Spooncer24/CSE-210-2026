using System.Runtime;

class BattleLogic
{
    private Player _player;
    private List<Goblin> _enemies;
    private Random _rand = new Random();
    private int _round = 1;

    public BattleLogic(Player player)
    {
        _player = player;
        _enemies = new List<Goblin>();
        SpawnGoblins();
    }

    private void SpawnGoblins()
    {
        int goblinCount = _rand.Next(1, 4); // 1-3 goblins
        char label = 'A';

        for (int i = 0; i < goblinCount; i++)
        {
            string name = $"Goblin {label}";
            int baseDmg = 5; // base damage
            _enemies.Add(new Goblin(name, baseDmg));
            label++;
        }
    }

    public void StartBattle()
    {
        Console.WriteLine($"Battle started! {_enemies.Count} goblins appear!");
        Thread.Sleep(2000); //Slow console down so player can read

        while (_player.CheckLife())
        {
            Console.Clear();
            Console.WriteLine($"\n--- Round {_round} ---");

            if (_enemies.Any(e => e.CheckLife()))
                PlayerTurn();
            else
            {
                Console.WriteLine("All goblins defeated!");
                HandleLoot();
                // Respawn new goblins for continuous battle
                _round = 1;
                SpawnGoblins();
                continue;
            }

            EnemyTurn();
            _round++;
        }

        Console.WriteLine("\nYou were defeated... Game Over!");
    }

    private void PlayerTurn()
    {
        Console.WriteLine($"\n{_player.GetName()}'s turn!");

        bool turnDone = false;

        while (!turnDone)
        {
            Console.WriteLine($"{_player.GetName()}'s HP: {_player.GetHP()}");
            Console.WriteLine("\nChoose action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Inventory");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AttackEnemy();
                    turnDone = true;
                    break;

                case "2":
                    OpenInventory();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    private void AttackEnemy()
    {
        var aliveGoblins = _enemies.Where(e => e.CheckLife()).ToList();

        Console.WriteLine("Choose a goblin to attack:");
        for (int i = 0; i < aliveGoblins.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {aliveGoblins[i].GetName()} (HP: {aliveGoblins[i].GetHP()})");
        }

        int choice = -1;
        while (choice < 1 || choice > aliveGoblins.Count)
        {
            Console.Write("Enter number: ");
            int.TryParse(Console.ReadLine(), out choice);
        }

        var target = aliveGoblins[choice - 1];
        _player.AttackMessage(target.GetName());
        target.TakeDamage(10);

        Console.WriteLine($"{target.GetName()} HP: {target.GetHP()}");

        if (!target.CheckLife())
            Console.WriteLine($"{target.GetName()} is defeated!");

        Thread.Sleep(2000);
    }

    private void EnemyTurn()
    {
        Console.WriteLine("\nEnemy turn!");
        foreach (var enemy in _enemies)
        {
            if (enemy.CheckLife())
            {
                int dmg = enemy.GetDMG() + _round; // scale with round
                Thread.Sleep(1000); //Slow console down so player can read
                enemy.AttackMessage(_player.GetName());
                Thread.Sleep(1000); //Slow console down so player can read
                _player.TakeDamage(dmg);
                Console.WriteLine($"{_player.GetName()} takes {dmg} damage! HP: {_player.GetHP()}");
                Thread.Sleep(1000); //Slow console down so player can read

                if (!_player.CheckLife())
                    break; // exit if player died
            }
        }
    }

    private void OpenInventory()
    {
        Console.Clear();
        Console.WriteLine("Inventory:");

        _player.ShowInventory();

        Console.WriteLine("\n1. Use Health Potion");
        Console.WriteLine("2. Back");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            _player.UsePotion();
            Thread.Sleep(2000);
        }
    }

    private void HandleLoot()
    {
        int goblinCount = _enemies.Count(e => e.CheckLife() == false);
        int potionChance = goblinCount * 30; // # is = % chance of a potion per goblin defeated
        int roll = _rand.Next(0, 100);
        if (roll < potionChance)
        {
            Console.WriteLine("You found a Health Potion!");
            _player.AddItem("Health Potion", 1);
            Thread.Sleep(1500); //Slow console down so player can read
        }
        else
        {
            Console.WriteLine("No loot found this time.");
            Thread.Sleep(1500); //Slow console down so player can read
        }
    }
}