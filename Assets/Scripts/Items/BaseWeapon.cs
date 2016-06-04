using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {             //BaseWeapon <- BaseStatItem <- BaseItem

	public enum WeaponTypes
	{
		SWORD, STAFF, BOW, SHEILD, MACE, DAGGER, AXE
	}

	private WeaponTypes weaponType;
	private int spellEffectID;


	public WeaponTypes WeaponType{ get; set; }
	public int SpellEffectID { get; set; }

}
