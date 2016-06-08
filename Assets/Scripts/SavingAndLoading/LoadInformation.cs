using UnityEngine;
using System.Collections;

public class LoadInformation {
	//allows all player saved information to be loaded
	public static void LoadAllInformation()
	{
		GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
		GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
		GameInformation.Stamina = PlayerPrefs.GetInt("STAMINA");
		GameInformation.Strength = PlayerPrefs.GetInt("STRENGTH");
		GameInformation.Intellect = PlayerPrefs.GetInt("INTELLECT");
		GameInformation.Endurance = PlayerPrefs.GetInt("ENDURANCE");
		GameInformation.Dexterity = PlayerPrefs.GetInt("DEXTERITY");
	}
}
