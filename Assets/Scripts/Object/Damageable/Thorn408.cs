using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thorn408 : Damageable408
{
    protected override void DoDamage(GameObject other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<Player408>().TakeDamage(1);
        }
    }
}
