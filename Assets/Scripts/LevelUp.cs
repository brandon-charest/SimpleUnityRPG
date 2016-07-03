using UnityEngine;
using System.Collections;

public class LevelUp {

	public void LevelUpPlayer()
    {
        //check to see if current XP is greater then required XP
        if(GameInformation.CurrentExperience >= GameInformation.RequiredExperience)
        {
            //keeps any excess experience from previous level (example: need 100 to level gained 120 from kill now start new level with 20 xp)
            GameInformation.CurrentExperience -= GameInformation.RequiredExperience;
        }
        else
        {
            GameInformation.CurrentExperience = 0;
        }


        //increase stat points
        //gift items
        //unlock  new ability
        //give money
        //determine new amount of required xp to level
        DetermineRequiredXP();
    }

    private void DetermineRequiredXP()
    {
        //TODO: find better level curve algorithm, current is linear
        int temp = (GameInformation.PlayerLevel * 1000) + 250;
        GameInformation.RequiredExperience = temp;
    }


    //private void determineMoneyToGive()
    //{        
    //}
}
