using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager408 : Singleton408<CoinManager408>
{
    public int coins;

    public void AddCoins(int amount)
    {
        coins += amount;
    }

    public void RemoveCoins(int amount)
    {
        coins -= amount;
    }
    
    
}
