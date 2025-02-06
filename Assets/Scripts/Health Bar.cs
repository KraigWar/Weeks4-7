using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float health = 10;
    public Slider healthSlider;
    void Start()
    {
        healthSlider.minValue = 0;
        healthSlider.maxValue = 10;
        healthSlider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        healthSlider.value = health;
    }
}
