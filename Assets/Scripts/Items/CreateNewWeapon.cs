using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;


	//to see if weapon creation works
	void Start()
	{
		CreateWeapon();
		Debug.Log(newWeapon.ItemName);	
		Debug.Log(newWeapon.ItemDescription);	
		Debug.Log(newWeapon.ItemID.ToString());	
		Debug.Log(newWeapon.WeaponType.ToString());	
		Debug.Log(newWeapon.Stamina.ToString());	
		Debug.Log(newWeapon.Endurance.ToString());	
	}

	//generate weapon
	public void CreateWeapon()
	{	
		newWeapon = new BaseWeapon();
		//assign weapon name, description
		newWeapon.ItemName = "W" + Random.Range(1, 101);
		newWeapon.ItemDescription = "This is a new Weapon!";
		//assign weapon id
		newWeapon.ItemID=Random.Range(1, 101);
		//assign weapon stats
		newWeapon.Stamina = Random.Range(1, 11);
		newWeapon.Strength = Random.Range(1, 11);
		newWeapon.Dexterity = Random.Range(1, 11);
		newWeapon.Intellect = Random.Range(1, 11);
		newWeapon.Endurance = Random.Range(1, 11);
		//assign weapon type
		ChooseWeaponType();
		//assign spell effect id
		newWeapon.SpellEffectID = Random.Range(1, 101);
	}

	private void ChooseWeaponType()
	{
		int randomTemp = Random.Range(1, 9);

		switch(randomTemp)
		{
			case 1:
				newWeapon.WeaponType = BaseWeapon.WeaponTypes.AXE;
				break;
			case 2:
				newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHEILD;
				break;
			case 3:
					newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
					break;
			case 4:
					newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
					break;
			case 5:
						newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
						break;
			case 6:
						newWeapon.WeaponType = BaseWeapon.WeaponTypes.MACE;
						break;
			case 7:
						newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
						break;
			case 8:
						newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
						break;
			default:
						Debug.Log("Default Case in Weapon Type Reached");
						break;
		} //end switch statement


	} //end ChooseWeaponType()


	
}
