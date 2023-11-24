using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCapsule408 : Collectable408
{
    protected override void Collect()
    {
        GameManager408.Instance.SaveData();
        UIManager408.Instance.GetPanel<NotifyPopup408>()
            .OnSetup("Congratulations!", "You have collected energy capsules on this map");
        base.Collect();
    }
}