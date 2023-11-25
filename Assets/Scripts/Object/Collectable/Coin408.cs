using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin408 : Collectable408
{
    protected override void Collect()
    {
        base.Collect();
        GameManager408.Instance.AddCoins(1);
        AudioManager408.Instance.PlaySound(1 , 1);
        gameObject.SetActive(false);
    }
}
 