using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {

	private BasePotion newPotion;
	// Use this for initialization
	void Start () {
		CreatePotion();
	
		Debug.Log(newPotion.ItemName);	
		Debug.Log(newPotion.ItemDescription);	
		Debug.Log(newPotion.ItemID.ToString());	
		Debug.Log(newPotion.PotionType.ToString());		
	}

	private void CreatePotion()
	{
		newPotion = new BasePotion();
		newPotion.ItemName = "Potion";
		newPotion.ItemDescription = "This is a potion.";
		newPotion.ItemID  = Random.Range(1, 101);
		ChoosePotion();
	}

	private void ChoosePotion()
	{
	 	int randomTemp = Random.Range(1,8);

	 	switch(randomTemp)
	 	{
	 		case 1:
	 			newPotion.PotionType = BasePotion.PotionTypes.ENDURANCE;
	 			break;
			case 2:
		 			newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
		 			break;
			case 3:
		 			newPotion.PotionType = BasePotion.PotionTypes.MANA;
		 			break;
			case 4:
		 			newPotion.PotionType = BasePotion.PotionTypes.HASTE;
		 			break;
			case 5:
		 			newPotion.PotionType = BasePotion.PotionTypes.STRENGTH;
		 			break;
			case 6:
		 			newPotion.PotionType = BasePotion.PotionTypes.SPEED;
		 			break;
			case 7:
		 			newPotion.PotionType = BasePotion.PotionTypes.INTELLECT;
		 			break;
			default:
					Debug.Log("Default case reached in creation potion type!");
					break;
	 	}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
