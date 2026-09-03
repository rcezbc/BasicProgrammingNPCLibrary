namespace NPCLibrary.Models;

/// <summary>
/// Represents a Non-Player Character (NPC) with various attributes.
/// </summary>
public class NPC
{
	public string FirstName { get; }
	public string LastName { get; }
	public DateTime DateOfBirth { get; }
	public string Gender { get; }
	public string? Description { get; set; }
	public string? Notes { get; set; }
	public int? Strength { get; set; }
	public int? Agility { get; set; }
	public int? Vitality { get; set; }

	/// <summary>
	/// Initializes a new instance of the NPC class with the specified details.
	/// </summary>
	/// <param name="firstName">The first name of the NPC.</param>
	/// <param name="lastName">The last name of the NPC.</param>
	/// <param name="dateOfBirth">The date of birth of the NPC.</param>
	/// <param name="gender">The gender of the NPC.</param>
	/// <param name="description">An optional description for the NPC.</param>
	/// <param name="notes">Optional notes for the NPC.</param>
	/// <param name="strength">An optional strength value for the NPC.</param>
	/// <param name="agility">An optional agility value for the NPC.</param>
	/// <param name="vitality">An optional vitality value for the NPC.</param>
	public NPC(
		string firstName, string lastName, DateTime dateOfBirth, string gender,
		string? description, string? notes, int? strength, int? agility, int? vitality)
	{
		FirstName = firstName;
		LastName = lastName;
		DateOfBirth = dateOfBirth;
		Gender = gender;
		
		if(description != null)
		{
			Description = description;
		}

		if(notes != null)
		{
			Notes = notes;
		}
		
		if(strength != null) 
		{
			Strength = strength;
		}
		
		if(agility != null) 
		{
			Agility = agility;
		}
		
		if(vitality != null)
		{
			Vitality = vitality;
		}
	}
	
	
}