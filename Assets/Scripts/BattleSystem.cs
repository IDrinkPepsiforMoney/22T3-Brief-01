using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
 public string winner;
    private void Start()
    {
        // let's start by setting our player dancing stats to random numbers
        // style should be random between 1-10
        int playerOneStyle = Random.Range (1,11);
        // luck should be random between 0-4
        int playerOneLuck = Random.Range (0,5);
        // ryhtm should be random between 1-6
        int playerOneRyhtm = Random.Range (1,7);
        // style should be random between 1-10
        int playerTwoStyle = Random.Range (1,11);
        // luck should be random between 0-4
        int playerTwoLuck = Random.Range (0,4);
        // ryhtm should be random between 1-6
        int playerTwoRyhtm = Random.Range (1,7);

        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        // this algorthim should be the same for each character to keep it fair.
        int playerOnePowerLevel = playerOneStyle + playerOneLuck + playerOneRyhtm;
        int playerTwoPowerLevel = playerTwoStyle + playerTwoLuck + playerTwoRyhtm;

        // Debug out the two players, power levels.
        Debug.Log ("WOOOAHGHG!! PLAYER ONE'S POWER LEVEL IS " + playerOnePowerLevel + 
        ", and PLAYER TWO's POweR LevEL iS! " + playerTwoPowerLevel);

        // calculate the percentage chance of winning the fight for each character.
        // todo this you'll need to add the two powers together, then divide you characters power against this and multiply the result by 100.
        int totalPower = playerOnePowerLevel + playerTwoPowerLevel;
        int playerOneChanceToWin = (int)(playerOnePowerLevel / (float)(totalPower) * 100f);
        int playerTwoChanceToWin = (int)(playerTwoPowerLevel / (float)(totalPower) * 100f);


        // Debug out the chance of each character to win.
        Debug.Log ("Player one has a " + playerOneChanceToWin + "% chance to win!!!" + "Player two has a " + playerTwoChanceToWin + "% chance to win!!!");

        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.  
       // Debug out which character has won, which has lost, or if it's a draw.
        if (playerOneChanceToWin > playerTwoChanceToWin)
        {
            int winsBy = playerOneChanceToWin - playerTwoChanceToWin;
            Debug.Log ("Player One has Won by a " + winsBy + "% margin");
            winner = "Player One!";
        }
        else if (playerOneChanceToWin < playerTwoChanceToWin)
        {
            int winsBy = playerTwoChanceToWin - playerOneChanceToWin;
            Debug.Log ("Player Two has Won by a " + winsBy + "% margin");
            winner = "Player Two!";
        }
        else if (playerOneChanceToWin == playerTwoChanceToWin)
        {
            Debug.Log ("UNBELIEVABLE FOLKS! THIS IS A DRAW!");
            winner = "bacon";
        }
        


        int playerOneXPReward = 10 + ((playerOneChanceToWin - playerTwoChanceToWin) / 10);
        int playerTwoXPReward = 10 + ((playerTwoChanceToWin - playerOneChanceToWin) / 10);
        
        if (winner == "Player One!")
        {
            Debug.Log (winner + " has recieved" + playerOneXPReward + "XP. and Player Two has recieved " + playerTwoXPReward + "XP.");
        }
        else if (winner == "Player Two!")
        {
            Debug.Log (winner + " has recieved" + playerTwoXPReward + "XP. and Player Two has recieved " + playerOneXPReward + "XP.");
        }
        else if (winner == "bacon")
        {
            Debug.Log ("It's a draw! Both players Recieve" + playerOneXPReward + "XP.");
        }
            // Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.
    }
}
