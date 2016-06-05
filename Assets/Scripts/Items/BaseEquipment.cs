using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseStatItem{

	public enum EquipmentTypes
	{
	HEAD, CHEST, SHOULDERS, LEGS, BOOTS, BRACER, HANDS, RINGS, CLOAK, NECK
	}

	private EquipmentTypes equipmentType;
	private int spellEffectID;

	public EquipmentTypes EquipmentType { get; set; }
	public int SpellEffectID { get; set;}
}
