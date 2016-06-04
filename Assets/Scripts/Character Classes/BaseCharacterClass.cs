using UnityEngine;
using System.Collections;

public class BaseCharacterClass  {

	private string characterClassName;
	private string characterClassDescription;

	//player stats
	private int stamina;
	private int endurance;
	private int strength;
	private int dexterity;
	private int intellect;

	//Getters and Setters
	public string CharacterClassName	{ get;  set; }
	public string CharacterClassDescription { get; set; }
	public int Staminia { get; set; }
	public int Endurance { get; set; }
	public int Strength { get; set; }
	public int Dexterity { get; set; }
	public int Intellect { get; set; }

}
