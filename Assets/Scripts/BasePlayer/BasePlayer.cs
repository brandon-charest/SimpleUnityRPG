using UnityEngine;
using System.Collections;

public class BasePlayer{

	private string playerName;
	private int playerLevel;
	private BaseCharacterClass playerClass;
	private int stamina, endurence, strength, intellect, dexterity;
    private int currentExperience;
    private int requiredExperience;

	public string PlayerName { get; set; }
	public int PlayerLevel { get; set; }
	public BaseCharacterClass PlayerClass { get; set; }
	public int Stamina { get; set;}
	public int Endurance { get; set;}
	public int Strength { get; set;}
	public int Intellect { get; set;}
	public int Dexterity { get; set;}
    public int CurrentExperience { get; set; }
    public int RequiredExperience { get; set; }
}
