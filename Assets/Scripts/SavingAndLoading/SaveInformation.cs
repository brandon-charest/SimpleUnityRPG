using UnityEngine;
using System.Collections;

public class SaveInformation  {

	//allow for all player information to be saved
	public static void SaveAllInformation()
	{
		PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
		PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefs.SetInt("STAMINA", GameInformation.Stamina);
		PlayerPrefs.SetInt("STRENGTH", GameInformation.Strength);
		PlayerPrefs.SetInt("INTELLECT", GameInformation.Intellect);
		PlayerPrefs.SetInt("ENDURANCE", GameInformation.Endurance);
		PlayerPrefs.SetInt("DEXTERITY", GameInformation.Dexterity);
		//for testing
		Debug.Log("SAVED ALL PLAYER INFORMATION");
	}
}
