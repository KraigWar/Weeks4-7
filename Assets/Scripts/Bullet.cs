using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //declaring a vector for the bullet
    Vector2 Bull;
    //setting the speed of the bullets
    public float s = 0.1f;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //subtract the speed from the vector to make it move to the left when it does spawn in
        Bull.x -= s;
        transform.position = Bull;
        //creating a variable relative to the screen view to make the bullet be destroyed depending on the screen rather than the world view
        Vector2 position = Camera.main.WorldToScreenPoint(transform.position);
        //if statement saying if the the postion realtive to the new found screen view goes outside of it (beyond 0), destroy that game object that was created
        if (position.x < 0)
        {
            Destroy(gameObject);
        }
    }
    //creating a function with an argument of its position to later call within the spawner for its location to be set =
    public void setSpawn(Vector2 pos)
    {

        transform.position = pos;
        Bull = transform.position;
    }
}
