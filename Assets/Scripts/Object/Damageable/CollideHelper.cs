using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideHelper : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag($"Player"))
        {
            GetComponent<Health408>().TakeDamage(1);
        }
    }
}
