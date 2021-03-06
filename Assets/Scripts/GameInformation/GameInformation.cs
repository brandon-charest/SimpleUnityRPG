﻿using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	//Awake is executed before Start()
	void Awake()
	{
		//hold player information when scenes are changed
		DontDestroyOnLoad(gameObject);
	}

	public static BaseEquipment EquipmentOne { get; set; }

	//player information to hold
	public static string PlayerName { get; set; }
	public static int PlayerLevel { get; set; }
	public static BaseCharacterClass PlayerClass { get; set; }
	public static int Stamina { get; set; }
	public static int Endurance { get; set; }
	public static int Strength { get; set; }
	public static int Intellect { get; set; }
	public static int Dexterity { get; set; }
    public static int CurrentExperience { get; set; }
    public static int RequiredExperience { get; set; }
}
