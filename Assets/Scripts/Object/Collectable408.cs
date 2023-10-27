using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable408 : MonoBehaviour
{
    
    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
        }
    }
    
    protected virtual void Collect()
    {
        Destroy(gameObject);
    }
    
    
    
}
