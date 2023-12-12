using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    //the int variable is being used to set the number of hits to 0
    int hits = 0;

    //the function is being declared to execute the code when the player hits a game object
    void OnCollisionEnter(Collision other)
    {
        //if the player hits another game object, the phrase "Hit" will appear on screen
        if (other.gameObject.tag != "Hit")
        {
            //when the player collides with game objects, the screen will tell you how many times
            hits++;
            Debug.Log("You bumped into a thing this many times: " + hits);
        }
    }

}
