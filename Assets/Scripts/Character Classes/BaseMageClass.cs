using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {

	public void Mage()
	{
		CharacterClassName = "Mage";
		CharacterClassDescription = "A hero with a affinity for magic, wears cloth armor.";

		Staminia = 12;
		Endurance = 9;
		Strength = 5;
		Dexterity = 5;
		Intellect = 15;
	}	
}
