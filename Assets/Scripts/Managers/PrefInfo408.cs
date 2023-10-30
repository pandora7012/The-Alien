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

    public static int GetChapter()
    {
        return PlayerPrefs.GetInt("Chapter", 0);
    }
    
    public static void SetChapter(int level)
    {
        PlayerPrefs.SetInt("Chapter", level);
    }

}
