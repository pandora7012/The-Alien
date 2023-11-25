using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMonster408 : Damageable408
{
    
    [SerializeField] private Health408 health;
    [SerializeField] private Patrolling408 patrolling408;
    
    private void Update()
    {
        patrolling408.Patrolling();
        
    }

   protected override void DoDamage(GameObject other)
   {
       base.DoDamage(other);
       if (other.CompareTag("Player"))
       {
           other.GetComponent<Player408>().TakeDamage(1);
       }
   }
   
   public void TakeDamage(int damage)
   {
       health.TakeDamage(damage);
   }
    
}
