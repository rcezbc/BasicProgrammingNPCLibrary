// See https://aka.ms/new-console-template for more information

namespace NPCLibrary;
using UI;

internal static class Program
{
	public static void Main(string[] args)
	{
		ConsolePrinter.PrintCentered("Welcome to the NPC Library!");
		
		ConsolePrinter.PrintCentered("Feel free to add NPCs...");
		
		while(true)
		{
			
		}
	}
}

//TODO: Create an actual "entry"/menu, which allows using the program

//TODO: Create a way to persist data, i.e. a save function, to actually persist data
//	- I'm thinking of just adding "serialise"- and "deserialise"-functions to my NPC class and then have a "DB-layer" which can persist in a file structure.

