using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //the number variable 'float' is used to set the player speed to float 10 units; the code will be able to be edited in Play Mode on Unity and run smoother
    [SerializeField] float playerSpeed = 10f;
    //the number variable is set for the y-value
    float yValue;
    //the playerRB variable will hold the Rigidbody component
    Rigidbody playerRB;

    // Start is called before the first frame update
    void Start()
    {
        //the functions are being set
        SetValueY();
        PrintInstructions();
        //the rigidbody is set to grab the component using teh GetComponent code 
        playerRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //a new function is being called
        PlayerMovement();
       
        //when the player presses the space bar, it will jump
        if (Input.GetButtonDown("Jump"))
        {
            //the phrase will be on the screen when the player jumps
            Debug.Log("I'm Jumping!");
            //the player will have the ability to jump
            playerRB.AddForce(Vector3.up * 6, ForceMode.Impulse);
        }
       
    }


    //the function is being declared, it will print instructions onto the screen
    void PrintInstructions()
    {
        //the following phrases will show up on the screen
        Debug.Log("Welcome to the Game.");
        Debug.Log("Move your player with WASD or Arrow Keys and Space Bar.");
        Debug.Log("Use F Key to destroy green object and G Key to recreate.");
        Debug.Log("Don't hit the wall or the objects! Get to the pink object!");


    }
    //the function is being declared, it will describe player movement
    void PlayerMovement()
    {
        //using the float variable, the x and z values are being set to move slower on the x and z axis
        float xValue = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;
        float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        //the player will move to the values set
        transform.Translate(-xValue, yValue, zValue);
       

    }

    // the function is being declared, it will set the y value
    void SetValueY()
    {
        //the player won't move on the y-axis
        yValue = 0f;
    }

}
