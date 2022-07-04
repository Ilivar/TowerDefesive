using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MinionSpawner : MonoBehaviour
{

    public GameObject minion;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    
    void Start()
    {
        InvokeRepeating("spawnObject", spawnTime, spawnDelay);
      
    }

    

    private void spawnObject()
    {
        Instantiate(minion, transform.position, transform.rotation);
        
        if (stopSpawning)
        {
            CancelInvoke("spawnObject");
        }

    }

    
}
