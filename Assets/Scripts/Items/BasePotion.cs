using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem {

	public enum PotionTypes
	{
	HEALTH, STRENGTH, INTELLECT, ENDURANCE, SPEED, HASTE, MANA
	}

	private PotionTypes potionType;
	private int spellEffectID;

	public PotionTypes PotionType { get; set; }
	public int SpellEffectID { get; set;}

}
