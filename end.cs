using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
  

    
    //a new function is being created to declare what happens when the player collides with said object
    void OnCollisionEnter(Collision other)
    {
        //if the player collides with the object, the following will occur
        if (other.gameObject.tag == "Player")
        {
            //the scene will change
            SceneManager.LoadScene("new scene");

        }
    }
}
