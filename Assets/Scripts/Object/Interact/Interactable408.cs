using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable408 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DoInteract();
        }
    }
    
    protected virtual void DoInteract()
    {
        //Destroy(gameObject);
    }
}
