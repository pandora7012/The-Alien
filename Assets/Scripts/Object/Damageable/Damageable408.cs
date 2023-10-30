using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable408 : MonoBehaviour
{
    
    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DoDamage();
        }
    }
    
    protected virtual void DoDamage()
    {
        
    }
}
