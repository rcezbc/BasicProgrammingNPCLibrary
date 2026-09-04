using NPCLibrary.Controllers;
using NPCLibrary.Models;
using NPCLibrary.UI;

namespace NPCLibrary.Actions;

public static class NpcCreate
{
	public static NPC Execute()
	{
		//Require some information from the user.
		ConsolePrinter.PrintCentered("Please provide the following information:");
		
		//TODO: Consider switching approach:
		// Reflect on NpcClass to ask for everything we need, generating a collection/DTO
		// and passing that to the controller instead of individual parameters.

		//TODO: Note the issue with empty values being passed here. Should probably differentiate on "optional".
		ConsolePrinter.PrintCentered($"Please provide a Firstname");
		string firstName = Console.ReadLine();
		ConsolePrinter.PrintCentered("Please provide a Lastname");
		string lastName = Console.ReadLine();
		ConsolePrinter.PrintCentered("Please provide a DateOfBirth");
		//TODO: This must be a real DateTime...
		string dateOfBirth = Console.ReadLine();
		ConsolePrinter.PrintCentered("Please provide a Gender");
		string gender = Console.ReadLine();
		ConsolePrinter.PrintCentered("Please provide a Description (optional)");
		string description = Console.ReadLine();
		ConsolePrinter.PrintCentered("Please provide any Notes (optional)");
		string notes = Console.ReadLine();
		ConsolePrinter.PrintCentered("Please provide a Strength (optional)");
		string strength = Console.ReadLine();
		ConsolePrinter.PrintCentered("Please provide a Agility (optional)");
		string agility = Console.ReadLine();
		ConsolePrinter.PrintCentered("Please provide a Vitality (optional)");
		string vitality = Console.ReadLine();
		
		//Create the NPC
		NPC npc = NpcController.Create(
			firstName:firstName, lastName:lastName, 
			dateOfBirth:dateOfBirth, gender:gender, 
			description:description, notes:notes, strength:strength, 
			agility:agility, vitality:vitality);
		
		//TODO: Persist the NPC
		
		//Return the NPC
		return npc;
	}
}