using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    //declaring the prefab object
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
        //This creates the object from the spawner using the arguments in the bullets code
        //It then sets the bullets position to be wherever the spawner is location not matter what
        GameObject spawnedBullet = GameObject.Instantiate(Bulf);
        Bullet bulletScript = spawnedBullet.GetComponent<Bullet>();
        bulletScript.setSpawn(transform.position);
    }
}