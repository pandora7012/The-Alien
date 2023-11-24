using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring408 : Interactable408
{
    protected override void DoInteract()
    {
        base.DoInteract();
        
        Debug.LogError("adsadasd");
        
        var data = UpgradeManager408.Instance.jumpData;
        var level = UIManager408.Instance.GetPanel<UpgradeUI408>().jumpLevel;
        var rb =  UIManager408.Instance.GetPanel<MainGame408>().cPlayer408.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2
            (0, data.values[level] / 1.5f);
    }
}
