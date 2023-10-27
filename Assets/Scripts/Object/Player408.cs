using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player408 : MonoBehaviour
{
    public Animation anim;
    [SerializeField] private Controller408 controller;
    [SerializeField] private Health408 health;

    private void Update()
    {
        controller.Controlling();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag($"Damageable"))
        {
            health.TakeDamage(1);
        }
    }
}
