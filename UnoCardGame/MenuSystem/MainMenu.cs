namespace MenuSystem;

public class MainMenu
{
    private const string lineSeparator = "======================";

    public void FirstMenu()
    {
        Console.WriteLine("UNO CARD GAME");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("MAIN MENU.");
        Console.WriteLine(lineSeparator);
        Console.WriteLine("s - Start New Game");
        Console.WriteLine("c - Continue");
        Console.WriteLine("l - Load Game");
        Console.WriteLine("e - Exit");
        Console.WriteLine(lineSeparator);
        Console.Write("Your choice: ");
        string? userChoice = Console.ReadLine();
        processUserInput(userChoice);
    }

    private void processUserInput(string? choice)
    {
        if (choice!.ToLower() == "s")
        {
            // set up players count, AI count, game mode
            Console.WriteLine("start");
        }
        else if (choice.ToLower() == "c")
        {
            //load last saved game from file
            Console.WriteLine("continue");
        }
        else if (choice.ToLower() == "l")
        {
            // load any played and saved game state from file
            Console.WriteLine("load game");
        }
        else if (choice.ToLower() == "e")
        {
            Environment.Exit(0);
        }
    }
    
    
}