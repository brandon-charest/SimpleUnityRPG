using UnityEngine;
using System.Collections;

public static class IncreaseExperienc
{
    private static int experienceToGain;
    public static void AddExperience()
    {
        //TODO: find better leveling up algor
        experienceToGain = GameInformation.PlayerLevel * 100;
        GameInformation.CurrentExperience += experienceToGain;
 


        Debug.Log(experienceToGain);
    }

    public static void AddExplorationExperience()
    {
        experienceToGain = GameInformation.PlayerLevel * 10;
        GameInformation.CurrentExperience += experienceToGain;
    }

    //private static CheckExperienceToLevel(int playerLevel)
    //{
    //    playerLevel += 1;
    //    int levels = 50;
    //    float xpLevel1 = 500.0f; //total experience required for a player to reach Level 2
    //    float xpLevel50 = 500000.0f; //total experience required to reach max level
    //    float temp1 = Mathf.Log(xpLevel50 / xpLevel1);
    //    float b = temp1 / (levels - 1);
    //    float temp2 = (Mathf.Exp(b) - 1);
    //    float a = (xpLevel1) / temp2;
    //    int oldXP = (int)(a * Mathf.Exp((float)b * (playerLevel - 1)));
    //    int newXP = (int)(a * Mathf.Exp((float)b * playerLevel));
    //    int temp = newXP - oldXP;
    //    temp = (int)Mathf.Round((float)temp / 10.0f) * 10; //rounding to nearest 10
    //    return temp;
    //}    
}
