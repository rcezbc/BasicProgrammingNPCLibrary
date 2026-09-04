namespace NPCLibrary.UI;

public static class Menu
{
	private static List<string> _menuOptions = new List<string>
	{
		"1. List all NPCs",
		"2. Show NPC",
		"3. Create NPC"
	};
	
	public static void ShowMenu()
	{
		// Clean up the UI for our menu.
		Console.Clear();
		
		// Print the actual Menu
		foreach(string option in _menuOptions)
		{
			ConsolePrinter.PrintMenu(option);
		}
		ConsolePrinter.PrintMenu("Please pick an option, writing the number from the menu that you want and pressing enter.");

		// Force the user to pick something from the menu
		bool legalChoice;
		int menuChoice;
		do
		{
			(legalChoice, menuChoice) = AskForMenuChoice();
		} while(! legalChoice);

		// Handle the menu choice - We don't have a default case, because we assume the above code enforces only valid values.
		switch(menuChoice)
		{
			case 1:
				ConsolePrinter.PrintCentered("Listing all NPCs...");
				
				break;
			case 2:
				ConsolePrinter.PrintCentered("Showing NPC...");
				break;
			case 3:
				ConsolePrinter.PrintCentered("Let's create an NPC...");
				break;
		}
	}

	private static (bool, int) AskForMenuChoice()
	{
		string? userInput = Console.ReadLine();

		bool success = int.TryParse(userInput, out int menuChoice);
		
		// Make sure that the user is making a legal choice
		if(success)
		{
			// Ascertain that menuChoice won't be out of bounds
			success = (_menuOptions.Count() >= menuChoice) && (menuChoice > 0);
		}

		return (success, menuChoice);
	}
}