using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector2 Bull;
    public float s = 0.1f;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bull.x -= s;
        transform.position = Bull;
        Vector2 position = Camera.main.WorldToScreenPoint(transform.position);
        if (position.x < 0)
        {
            Destroy(gameObject);
        }
    }
    public void setSpawn(Vector2 pos)
    {
        transform.position = pos;
        Bull = transform.position;
    }
}
