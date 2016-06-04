using UnityEngine;
using System.Collections;

//inherits from base class for character creation
public class BaseWarriorClass : BaseCharacterClass {

	public BaseWarriorClass()
	{
		CharacterClassName = "Warrior";
		CharacterClassDescription = "A strong and powerful hero, capable of wearing plate armor and weilding heavy weapons.";
		Staminia = 15;
		Endurance = 12;
		Dexterity = 6;
		Intellect = 5;
		Strength = 14;
	}
}
