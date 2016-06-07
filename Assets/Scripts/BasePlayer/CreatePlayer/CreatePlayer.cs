using UnityEngine;
using System.Collections;

public class CreatePlayer : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isMageClass;
	private bool isWarriorClass;
	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		isMageClass = GUILayout.Toggle(isMageClass, "Mage Class");
		isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");
		//choose class type
		if(GUILayout.Button("Create"))
		{
			if(isMageClass)
			{
				newPlayer.PlayerClass = new BaseMageClass();
			}
			else if(isWarriorClass)
			{
				newPlayer.PlayerClass = new BaseWarriorClass();
			}

			//create bew player and set stats
			//find better way to do this?
			newPlayer.PlayerLevel = 1;
			newPlayer.Stamina = newPlayer.PlayerClass.Staminia;
			newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
			newPlayer.Strength = newPlayer.PlayerClass.Strength;
			newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
			newPlayer.Endurance = newPlayer.PlayerClass.Endurance;

			//testing output
				Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
				Debug.Log("Player Level: " + newPlayer.PlayerLevel);
				Debug.Log("Player Stamina: " + newPlayer.Stamina);
				Debug.Log("Player Strength: " + newPlayer.Strength);
				Debug.Log("Player Intellect: " + newPlayer.Intellect);
				Debug.Log("Player Endurance: " + newPlayer.Endurance);
				Debug.Log("Player Dexterity: " + newPlayer.Dexterity);
		}
	}
}
