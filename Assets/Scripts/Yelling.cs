using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yelling : MonoBehaviour
{
    //declaring the game object
    public GameObject Yell;
    //declaring the variable for time
    float t;
    //boolean to check if the gme is playing or not
    bool isplay;
    // Start is called before the first frame update
    void Start()
    {
        //start with the words not appearing to be turned on later
        Yell.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if statement to start the timer if its playing
        if (isplay)
        {
            t += Time.deltaTime;
        }
        //if statment to reset the timer to 0 and make the words disapear after a certain amount of time
        if (t > 1) { t = 0; isplay = false; Yell.SetActive(false); } 
    }

    public void activate()
    {
        //function the button will activate to make the words appear and to start the timer
            isplay = true;
            Yell.SetActive(true);
    }
}
