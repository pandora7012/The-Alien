using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thorn : Damageable408
{
    protected override void DoDamage(GameObject other)
    {
        base.DoDamage(other);
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player408>().TakeDamage(1);
        }
    }
}
