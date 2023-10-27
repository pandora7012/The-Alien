using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PrefInfo408
{
    public static void SetCoin(int amount)
    {
        PlayerPrefs.GetInt("Coin", amount);
    }

    public static int GetCoin()
    {
        return PlayerPrefs.GetInt("Coin");
    }

}
