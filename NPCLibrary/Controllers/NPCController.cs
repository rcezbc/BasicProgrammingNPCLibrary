using NPCLibrary.Models;

namespace NPCLibrary.Controllers;

public static class NpcController
{
	private static List<NPC> _npcs = new List<NPC>();
	
	/// <summary>
	/// Creates and stores a new NPC with the provided details.
	/// </summary>
	/// <param name="firstName">The first name of the NPC.</param>
	/// <param name="lastName">The last name of the NPC.</param>
	/// <param name="dateOfBirth">The date of birth of the NPC.</param>
	/// <param name="gender">The gender of the NPC.</param>
	/// <param name="description">An optional description for the NPC.</param>
	/// <param name="notes">Optional new notes for the NPC.</param>
	/// <param name="strength">An optional new strength value for the NPC.</param>
	/// <param name="agility">An optional new agility value for the NPC.</param>
	/// <param name="vitality">An optional new vitality value for the NPC.</param>
	/// <returns>The newly created NPC object.</returns>
	public static NPC Create(
		string firstName, string lastName, DateTime dateOfBirth, string gender,
		string? description, string? notes, int? strength, int? agility, int? vitality)
	{
		NPC newNpc = new NPC(firstName, lastName, dateOfBirth, gender, description, notes, strength, agility, vitality);
		
		_npcs.Add(newNpc);
		
		return newNpc;
	}
	
	/// <summary>
	/// Returns an array of all NPCs currently stored.
	/// </summary>
	/// <returns>An array of NPC objects.</returns>
	public static NPC[] List()
	{
		//TODO: Consider only returning the name of the npcs
		return _npcs.ToArray();
	}

	/// <summary>
	/// Retrieves a specific NPC by its number (index).
	/// </summary>
	/// <param name="npcNumber">The zero-based index of the NPC to retrieve.</param>
	/// <returns>The NPC object at the specified index.</returns>
	public static NPC Show(int npcNumber)
	{
		return _npcs[npcNumber];
	}
	
	/// <summary>
	/// Updates the details of an existing NPC.
	/// Only provided non-null parameters will update the NPC's corresponding properties.
	/// </summary>
	/// <param name="npcNumber">The index of the NPC in the internal list to update.</param>
	/// <param name="description">An optional new description for the NPC.</param>
	/// <param name="notes">Optional new notes for the NPC.</param>
	/// <param name="strength">An optional new strength value for the NPC.</param>
	/// <param name="agility">An optional new agility value for the NPC.</param>
	/// <param name="vitality">An optional new vitality value for the NPC.</param>
	/// <returns>The updated NPC object.</returns>
	public static NPC Update(int npcNumber, string? description, string? notes, int? strength, int? agility, int? vitality)
	{
		NPC npcWeWorkOn = _npcs[npcNumber];
		
		if(description != null)
		{
			npcWeWorkOn.Description = description;
		}

		if(notes != null)
		{
			npcWeWorkOn.Notes = notes;
		}
		
		if(strength != null) 
		{
			npcWeWorkOn.Strength = strength;
		}
		
		if(agility != null) 
		{
			npcWeWorkOn.Agility = agility;
		}
		
		if(vitality != null)
		{
			npcWeWorkOn.Vitality = vitality;
		}
		
		return npcWeWorkOn;
	}
}