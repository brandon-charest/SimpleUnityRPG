using UnityEngine;
using System.Collections;

public class BasePostion : BaseStatItem {

	public enum PostionTypes
	{
	HEALTH, STRENGTH, INTELLECT, ENDURANCE, SPEED, HASTE, MANA
	}

	private PostionTypes postionType;
	private int spellEffectID;

	public PostionTypes PostionType { get; set; }
	public int SpellEffectID { get; set;}

}
