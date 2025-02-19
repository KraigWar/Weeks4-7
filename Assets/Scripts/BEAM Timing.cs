using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BEAMTiming : MonoBehaviour
{
    //initializing the animation curve
    public AnimationCurve curve;
    //initializing the slider game object to manipulate later
    Slider slider;
    //initializning timer variable
    float t;
    //boolean to deactivate the animation after use and to use for the button
    bool isShooting;
    void Start()
    {
        //grabbing the slider commponents to be changed later
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        //set the slider to be based off the animation curve set
        slider.value = curve.Evaluate(t);
        //i statement to check if tis shooting and if it is start the timer
        if (isShooting)
        {
            t += Time.deltaTime;
        }
        //if statment to resart the timer and animation to be later used
        if(t > 1)
        {
            t = 0;
            isShooting = false;
       
        }
    }

    public void shoot()
    {
        //shoot function to trigger with the designated button
        //set the boolean to be true when activated
        isShooting = true;
    }
}
