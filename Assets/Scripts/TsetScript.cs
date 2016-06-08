﻿using UnityEngine;
using System.Collections;

public class TsetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	//testing to make sure load player information is working
		LoadInformation.LoadAllInformation();
		Debug.Log("Player Name: " + GameInformation.PlayerName);
		Debug.Log("Player Level: " + GameInformation.PlayerLevel);
		Debug.Log("Player Stamina: " + GameInformation.Stamina);
		Debug.Log("Player Strength: " + GameInformation.Strength);
		Debug.Log("Player Intellect: " + GameInformation.Intellect);
		Debug.Log("Player Endurance: " + GameInformation.Endurance);
		Debug.Log("Player Dexterity: " + GameInformation.Dexterity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
