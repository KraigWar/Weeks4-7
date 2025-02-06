using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1;
    public GameObject Reaction;
    public Transform npcPos;
    public float dis = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Reaction.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 pos = transform.position;
            pos.y += speed * Time.deltaTime;
           
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 pos = transform.position;
            pos.x += speed * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 pos = transform.position;
            pos.y -= speed * Time.deltaTime;

            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 pos = transform.position;
            pos.x -= speed * Time.deltaTime;
 
            transform.position = pos;
        }
        Vector2 line = transform.position - npcPos.position;
        float dist = line.magnitude;

        if(dist < dis)
        {
            Reaction.SetActive(true);
        }
        else
        {
            Reaction.SetActive(false);
        }
      
    }
}
