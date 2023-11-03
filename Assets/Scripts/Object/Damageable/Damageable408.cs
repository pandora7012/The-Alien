using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable408 : MonoBehaviour
{
    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        DoDamage(other.gameObject);
    }

    protected virtual void OnCollisionEnter2D(Collision2D other)
    {
        DoDamage(other.gameObject);
    }

    protected virtual void DoDamage(GameObject other)
    {
    }
}