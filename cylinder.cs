using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder : MonoBehaviour
{
    //the number variable is set to float .3 units
    float movementSpeed = .3f;
    // Start is called before the first frame update
    void Start()
    {

      

    }

    // Update is called once per frame
    void Update()
    { 
        //the game object will rotate .3 units on the x-axis as it floats
         transform.Rotate(movementSpeed, 0, 0); 
    }
        

      
}
