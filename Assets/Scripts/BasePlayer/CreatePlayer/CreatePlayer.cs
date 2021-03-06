﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CreatePlayer : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isMageClass;
	private bool isWarriorClass;
	private string playerName = "Enter Name: ";

	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		playerName = GUILayout.TextArea(playerName, 15);
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

			//create new player and set stats			
			newPlayer.PlayerLevel = 1;
			newPlayer.Stamina = newPlayer.PlayerClass.Staminia;
			newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
			newPlayer.Strength = newPlayer.PlayerClass.Strength;
			newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
			newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
			newPlayer.PlayerName = playerName;

			StoreNewPlayerInformation();
			//save player information after creation
			SaveInformation.SaveAllInformation();

			//testing output
				Debug.Log("Player Name: " + newPlayer.PlayerName);
				Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
				Debug.Log("Player Level: " + newPlayer.PlayerLevel);
				Debug.Log("Player Stamina: " + newPlayer.Stamina);
				Debug.Log("Player Strength: " + newPlayer.Strength);
				Debug.Log("Player Intellect: " + newPlayer.Intellect);
				Debug.Log("Player Endurance: " + newPlayer.Endurance);
				Debug.Log("Player Dexterity: " + newPlayer.Dexterity);
		}

		if(GUILayout.Button("Load"))
		{
			Debug.Log("Load pressed");

			SceneManager.LoadScene("tset");
		}
	}
	//gathers all player information and stores it waiting for information to be saved
	//from SaveAllInformation()
	private void StoreNewPlayerInformation()
	{
		GameInformation.PlayerName = newPlayer.PlayerName;
		GameInformation.PlayerLevel = newPlayer.PlayerLevel;	
		GameInformation.Stamina = newPlayer.Stamina;
		GameInformation.Strength = newPlayer.Strength;
		GameInformation.Intellect = newPlayer.Intellect;
		GameInformation.Endurance = newPlayer.Endurance;
		GameInformation.Dexterity = newPlayer.Dexterity;
	}
}
