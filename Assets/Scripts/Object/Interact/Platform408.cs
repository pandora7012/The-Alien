using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform408 : Interactable408
{


    [SerializeField] private Patrolling408 _patrolling408;
    // Update is called once per frame
    void Update()
    {
        _patrolling408.Patrolling();
    }

    protected override void DoInteract()
    {
        base.DoInteract();
        
    }
}
