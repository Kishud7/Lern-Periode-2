using System;

Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Minecraft Random Item Generator:");
Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine(" ");
Console.WriteLine("Obtainability:");
Console.WriteLine("Survival = 1");
Console.WriteLine("Creative = 2");
int gamemode = Convert.ToInt32(Console.ReadLine());

if (gamemode == 1)
{
    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("Survival:");
    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine(" ");
    Console.WriteLine("Item of Origin:");
    Console.WriteLine("Overworld Dimension = 1");
    Console.WriteLine("Nether Dimension = 2");
    Console.WriteLine("End Dimension = 3");
    int dimension = Convert.ToInt32(Console.ReadLine());

    if (dimension == 1)
    {
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Overworld Dimension:");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine(" ");
        Console.WriteLine("Choose your difficulty:");
        Console.WriteLine("Easy = 1");
        Console.WriteLine("Medium = 2");
        Console.WriteLine("Hard = 3");
        Console.WriteLine("Random = 4");
        int OverworldDifficulty = Convert.ToInt32(Console.ReadLine());

        if (OverworldDifficulty == 1)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Easy:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            string[] SurvivalOverworldEasy = File.ReadAllLines("OverworldEasy.txt");
            Random random = new Random();
            int num = random.Next(0, SurvivalOverworldEasy.Length);
            Console.WriteLine("Your random item is: " + SurvivalOverworldEasy[num]);
        }

        if (OverworldDifficulty == 2)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Medium:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            string[] SurvivalOverworldMedium = File.ReadAllLines("OverworldMedium.txt");
            Random random = new Random();
            int num = random.Next(0, SurvivalOverworldMedium.Length);
            Console.WriteLine("Your random item is: " + SurvivalOverworldMedium[num]);
        }

        if (OverworldDifficulty == 3)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Hard:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            string[] SurvivalOverworldHard = File.ReadAllLines("OverworldHard.txt");
            Random random = new Random();
            int num = random.Next(0, SurvivalOverworldHard.Length);
            Console.WriteLine("Your random item is: " + SurvivalOverworldHard[num]);
        }

        if (OverworldDifficulty == 4)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Random:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            string[] SurvivalOverworldRandom = File.ReadAllLines("OverworldItems.txt");
            Random random = new Random();
            int num = random.Next(0, SurvivalOverworldRandom.Length);
            Console.WriteLine("Your random item is: " + SurvivalOverworldRandom[num]);
        }

    }
    if (dimension == 2)
    {
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Nether Dimension:");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine(" ");
        Console.WriteLine("Choose your difficulty:");
        Console.WriteLine("Easy = 1");
        Console.WriteLine("Medium = 2");
        Console.WriteLine("Hard = 3");
        Console.WriteLine("Random = 4");
        int NetherDifficulty = Convert.ToInt32(Console.ReadLine());

        if (NetherDifficulty == 1)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Easy:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        }

        if (NetherDifficulty == 2)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Medium:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        }

        if (NetherDifficulty == 3)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Hard:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        }

        if (NetherDifficulty == 4)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Random:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            string[] SurvivalNetherRandom = File.ReadAllLines("NetherItems.txt");
            Random random = new Random();
            int num = random.Next(0, SurvivalNetherRandom.Length);
            Console.WriteLine("Your random item is: " + SurvivalNetherRandom[num]);
        }

    }
    if (dimension == 3)
    {
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("End Dimension:");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine(" ");
        Console.WriteLine("Choose your difficulty:");
        Console.WriteLine("Easy = 1");
        Console.WriteLine("Medium = 2");
        Console.WriteLine("Hard = 3");
        Console.WriteLine("Random = 4");
        int EndDifficulty = Convert.ToInt32(Console.ReadLine());

        if (EndDifficulty == 1)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Easy:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        }

        if (EndDifficulty == 2)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Medium:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        }

        if (EndDifficulty == 3)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Hard:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        }

        if (EndDifficulty == 4)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Random:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            string[] SurvivalEndRandom = File.ReadAllLines("EndItems.txt");
            Random random = new Random();
            int num = random.Next(0, SurvivalEndRandom.Length);
            Console.WriteLine("Your random item is: " + SurvivalEndRandom[num]);
        }
    }
    if (gamemode == 2)
    {
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Creative:");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine(" ");
        Console.WriteLine("Random 1");
        int CreativeSelection = Convert.ToInt32(Console.ReadLine());



        if (CreativeSelection == 1)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Random:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------"); string[] CreativeRandom = File.ReadAllLines("CreativeItems.txt");
            Random random = new Random();
            int num = random.Next(0, CreativeRandom.Length);
            Console.WriteLine("Your random item is: " + CreativeRandom[num]);
        }

    }

}