using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionMovement : MonoBehaviour
{
    public Vector3 targetPosition;
    public float moveSpeed;


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        
        
    }
    
    void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject);
    }
        
}
