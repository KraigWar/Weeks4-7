using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BEAMTiming : MonoBehaviour
{
    public AnimationCurve curve;
    Slider slider;
    float t;
    bool isShooting;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = curve.Evaluate(t);

        if (isShooting)
        {
            t += Time.deltaTime;
        }
        if(t > 1)
        {
            t = 0;
            isShooting = false;
       
        }
    }

    public void shoot()
    {
        isShooting = true;
    }
}
