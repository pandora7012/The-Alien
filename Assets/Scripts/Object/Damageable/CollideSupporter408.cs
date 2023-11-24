using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSupporter408 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.parent.parent.GetComponent<Health408>().TakeDamage(1);
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 2);
        }
    }
}
