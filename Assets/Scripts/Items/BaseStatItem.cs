using UnityEngine;
using System.Collections;

[System.Serializable] //tells compiler that this class is serializable
public class BaseStatItem : BaseItem {

	private int stamina;
	private int endurance;
	private int intellect;
	private int strength;
	private int dexterity;

	public int Stamina {get; set;}
	public int Endurance {get; set;}
	public int Intellect {get; set;}
	public int Strength {get; set;}
	public int Dexterity {get; set;}
}
