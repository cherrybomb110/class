using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    //the variable renderer is being used to hold the MeshRenderer component 
    MeshRenderer renderer;
    //the variable rigidBuddy is being used to hold the Rigidbody component 
    Rigidbody rigidBuddy;
    //the  number variable is being set to float 5 units
    [SerializeField] float timetoWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //the MeshRenderer is being set to grab the component using the GetComponent snippet
        renderer = GetComponent<MeshRenderer>();
        //the Rigidbody is being set to grab the component using the GetComponent snippet
        rigidBuddy = GetComponent<Rigidbody>();
        //the game object is invisible
        renderer.enabled = false;
        //the game object can't move
        rigidBuddy.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if the time is more than the set number of 5, the following will occur
        if (Time.time > timetoWait)
        {
            //Debug.Log("Three seconds has passed; drop object!");
            //the game object will become visible
            renderer.enabled = true;
            //the game object will drop
            rigidBuddy.useGravity = true;

        }
    }
}
