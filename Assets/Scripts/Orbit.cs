using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    //set speed to an amount I want to rotate it by
    public float speed = 50;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //haev the object rotate arounf the object based on the speed set witht eh time that has passed
        transform.Rotate(0, 0, speed * Time.deltaTime);

    }
}
