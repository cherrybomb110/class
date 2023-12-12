using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class obliterate : MonoBehaviour
{ 
    //the game object is stored as guygameobject
    public GameObject guygameobject;
    //the variable is  declared
    public GameObject instantiateObjectHere;
    //the variable newInstance is declared
    private GameObject newInstance;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //the code will grab input from Unity Input Manager once the F key is pressed
      if(Input.GetKeyDown(KeyCode.F))
        {   //a new function is being called
            DestroyPrefab(); 
        }
        //the code will grab input from Unity Input Manager once the G key is pressed
        if (Input.GetKeyDown(KeyCode.G))
        {
            //a function is being called
            CreatePrefab();
        }
    }

    //a new function is declared to create the game object
    public void CreatePrefab()
    {
        //the number variables are set for the x and y axis
        float instX = instantiateObjectHere.transform.position.x;
        float instY = instantiateObjectHere.transform.position.y;
        //the new object will appear in the same position as the removed object
        newInstance = Instantiate(guygameobject, new Vector3(instX, instY, 0), Quaternion.identity);
    }

    //a new function is declared to destroy the game object
    public void DestroyPrefab()
    {
        //the game object has been destroyed
        Destroy(newInstance);
    }

}
