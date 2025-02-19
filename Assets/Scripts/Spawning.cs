using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject Bulf;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
 
    }

    public void spawner()
    {
        GameObject spawnedBullet = GameObject.Instantiate(Bulf);
        Bullet bulletScript = spawnedBullet.GetComponent<Bullet>();
        bulletScript.setSpawn(transform.position);
    }
}