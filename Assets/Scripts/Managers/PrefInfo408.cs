using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PrefInfo408
{
    public static void SetCoin(int amount)
    {
        PlayerPrefs.SetInt("Coin", amount);
        Debug.Log("Set Coin: " + amount);
    }

    public static int GetCoin()
    {
        Debug.LogError("Coin " + PlayerPrefs.GetInt("Coin"));
        return PlayerPrefs.GetInt("Coin");
    }

    public static void SetHealth(int amount)
    {
        PlayerPrefs.SetInt("Health", amount);
    }

    public static int GetHealth()
    {
        Debug.LogError("Health " + PlayerPrefs.GetInt("Health"));
        return PlayerPrefs.GetInt("Health", 0);
    }

    public static int GetChapter()
    {
        return PlayerPrefs.GetInt("Chapter", 0);
    }

    public static void SetChapter(int level)
    {
        PlayerPrefs.SetInt("Chapter", level);
    }

    public static void SetHealthLevel(int level)
    {
        PlayerPrefs.SetInt("HealthLevel", level);
    }

    public static int GetHealthLevel()
    {
        return PlayerPrefs.GetInt("HealthLevel", 0);
    }

    public static void SetSpeedLevel(int level)
    {
        PlayerPrefs.SetInt("SpeedLevel", level);
    }

    public static int GetSpeedLevel()
    {
        return PlayerPrefs.GetInt("SpeedLevel", 0);
    }

    public static void SetJumpPowerLevel(int level)
    {
        PlayerPrefs.SetInt("JumpPowerLevel", level);
    }

    public static int GetJumpPowerLevel()
    {
        return PlayerPrefs.GetInt("JumpPowerLevel", 0);
    }
}