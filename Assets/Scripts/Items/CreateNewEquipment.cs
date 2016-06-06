using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {

	private BaseEquipment newEquipment;
	/*names can be generated similar to weapon names but for the sake of learning
	**equiment will have names chosen from a given array list*/
	private string[] itemNames = new string[6] {"Common", "Uncommon", "Unique", "Epic", "Legendary", "Artifact"};
	//TODO finish item descriptions, current names are for testing
	private string[] itemDescription = new string[2] {"A new item!","A different new item!"};
	// Used to test equipment creatino
	void Start () {
		CreateEquipment();
		Debug.Log(newEquipment.ItemName);	
		Debug.Log(newEquipment.ItemDescription);	
		Debug.Log(newEquipment.ItemID.ToString());	
		Debug.Log(newEquipment.EquipmentType.ToString());	
		Debug.Log(newEquipment.Stamina.ToString());	
		Debug.Log(newEquipment.Endurance.ToString());	
	}

	private void CreateEquipment()
	{
		newEquipment = new BaseEquipment();
		//randomly choose index value for equipment name
		newEquipment.ItemName = itemNames[Random.Range(0, 6)] + " Item";
		newEquipment.ItemID = Random.Range(1, 101);
		ChooseItemType();
		newEquipment.ItemDescription = itemDescription[Random.Range(0, itemDescription.Length)];
		newEquipment.Stamina = Random.Range(1, 11);
		newEquipment.Strength = Random.Range(1, 11);
		newEquipment.Dexterity = Random.Range(1, 11);
		newEquipment.Intellect = Random.Range(1, 11);
		newEquipment.Endurance = Random.Range(1, 11);
	}

	private void ChooseItemType()
	{
		int randomTemp = Random.Range(1, 11);
		switch(randomTemp)
		{
			case 1:
				newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
				break;
			case 2:
					newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
					break;
			case 3:
					newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERS;
					break;
			case 4:
					newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
					break;
			case 5:
					newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BOOTS;
					break;
			case 6:
					newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BRACER;
					break;
			case 7:
					newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HANDS;
					break;
			case 8:
					newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RINGS;
					break;
			case 9:
					newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CLOAK;
					break;
			case 10:
					newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
					break;
			default:
				Debug.Log("Default case reached in equipment type!");
					break;
		}//end switch

	}

	// Update is called once per frame
	void Update () {
	
	}
}
