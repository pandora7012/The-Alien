using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCapsule408 : Collectable408
{
    protected override void Collect()
    { 
        Debug.LogError("Show Popup Noti ");
        GameManager408.Instance.NextChapter();
        base.Collect();
    }
}
