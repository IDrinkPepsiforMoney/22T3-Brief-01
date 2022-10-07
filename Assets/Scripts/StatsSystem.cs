using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    /// Our physical stats that determine our dancing stats.
    public int agility;
    public int intelligence;
    public int strength;

    // Our variables used to determine our fighting power.
    public int style;
    public int luck;
    public int rhythm;

    //public bool lvlUp;
    private void Start()
    {
        // set out agility, strength and intelligence to a random number between zero and ten.
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        strength = (0 + Random.Range(0,11));
        agility = (0 + Random.Range(0,11));
        intelligence = (0 + Random.Range(0,11));
        //lvlUp = false;


        // Debug out your current physical stat values (strength, agility, intelligence).

            Debug.Log("Your strenght is " + strength + 
                    ", Your Agility is " + agility + 
                    ", You have " + intelligence + " intelligence.");
        // let's create some float temporary variables to hold our multiplier values.

        // create an agility multiplier should be set to 0.5
        
        // create a strength multiplier should be set to 1

        // create an intelligence multiplier should be set to 2.

        // Debug out our current multiplier values.

        // now that we have some stats and our multiplier values let's calculate our style, luck and ryhtmn based on these values.

        // style should be based off our strength and be converted at a rate of 1 : 1.
        style = ((int)(strength * (0.2f * (float)agility)));
        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        luck = ((int)(intelligence * (0.2f * (float)agility)));
        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.
        rhythm = ((int)(agility * (0.2f * (float)intelligence)));

        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log("You got' " + style + " style! and " 
        + luck + " luck, Y'also'got a total of " +
        rhythm + " rhythm wowie!");

       
        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence. 
   
        // for later : if (lvlUp = true)
        {
       // Makes a variable of 10 points
        int additionalPoints = 10;
        
        // Adds a 3rd of that variable to strength, intelligence and agility respectively.
        strength = (strength + (additionalPoints / 3));
        intelligence = (intelligence + (additionalPoints / 3));
        agility = (agility + (additionalPoints / 3));

        // Recalculates style luck and rythm with new stats.
        style = ((int)(strength * (0.2f * (float)agility)));
        luck = ((int)(intelligence * (0.2f * (float)agility)));
        rhythm = ((int)(agility * (0.2f * (float)intelligence)));
        
        //Tells us we leveled up, and what our new stats are.
         Debug.Log("YOU LEVELED UP!!! ... NEW STATS Your strength is " + strength + 
                    ", Your Agility is " + agility + 
                    ", You have " + intelligence + " intelligence." + "You got' " + style + " style! and " 
        + luck + " luck, Y'also'got a total of " +
        rhythm + " rhythm wowie!");


        //resets the level up bool
       // don't need this in the quicce build lvlUp = false;
        };

        // Debug out our new physical stat values

        // let's recalculate our style, luck and rhytmn as our initial stats have changed.
        
        // Debug out our new dancing stat values
    }
}
