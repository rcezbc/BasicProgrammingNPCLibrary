namespace NPCLibrary.UI;

public static class ConsolePrinter
{
	public static void Print(string text)
	{
		//Make sure we have no other dirt in the console.
		Console.Clear();
		
		CenterConsole(text);
		
		Console.WriteLine(text);
		
		// Add a delay, to make sure the user has time to read the displayed text.
		Thread.Sleep(1500);
	}

	private static void CenterConsole(string text)
	{
		// Get console dimensions
		int consoleWidth = Console.WindowWidth;
		int consoleHeight = Console.WindowHeight;
		int leftPosition = CalculateTextLeftOffset(text, consoleWidth);
		int topPosition = CalculateTextTopOffset(consoleHeight);
		
		Console.SetCursorPosition(leftPosition, topPosition);
	}

	private static int CalculateTextLeftOffset(string text, int consoleWidth)
	{
		int leftPosition = (consoleWidth - text.Length) / 2;
		
		// Ensure leftPosition is not negative if text is too wide
		if (leftPosition < 0)
		{
			leftPosition = 0;
		}
		
		// Calculate the number of spaces needed on the left side
		//  Integer division automatically handles any remainder, effectively rounding down
		return leftPosition;
	}

	private static int CalculateTextTopOffset(int consoleHeight)
	{
		return consoleHeight / 2;
	}
}