using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health408 : MonoBehaviour
{
    public int health = 3;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
        }
    }
    
    
    
}
