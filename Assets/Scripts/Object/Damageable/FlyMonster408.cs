using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMonster408 : Damageable408
{
    [SerializeField] private Health408 health;
    [SerializeField] private Patrolling408 patrolling408;


    private void Update()
    {
        patrolling408.Patrolling();
    }

}
