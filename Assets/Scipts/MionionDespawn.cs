using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MionionDespawn : MonoBehaviour
{
    public GameObject minion;
    
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
