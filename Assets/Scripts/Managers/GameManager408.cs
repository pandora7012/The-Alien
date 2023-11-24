using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager408 : Singleton408<GameManager408>
{
    public int coins;
    public GameObject[] maps;


    public void AddCoins(int amount)
    {
        coins += amount;
    }


    public void SaveData()
    {
        PrefInfo408.SetCoin(coins);
        PrefInfo408.SetChapter(PrefInfo408.GetChapter() + 1);

        var currentHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health408>().health;
        PrefInfo408.SetHealth(currentHealth);

        UpgradeManager408.Instance.SaveUpgradeData();
    }


    public void NextChapter()
    {
        var currentLevel = PrefInfo408.GetChapter();


        for (int i = 0; i < maps.Length; i++) maps[i].gameObject.SetActive(i == currentLevel - 1);

        UIManager408.Instance.GetPanel<MainGame408>().OnSetup();
    }

    public void OnCompleteGame()
    {   
    }


    public void OnGameOver()
    {
        UIManager408.Instance.GetPanel<MainGame408>().OnHide();
        UIManager408.Instance.GetPanel<MainMenu408>().OnShow();
        foreach (var map in maps)
        {
            map.gameObject.SetActive(false);
        }
    }


    public void StartNewGame()
    {
        PlayerPrefs.DeleteAll();
        PrefInfo408.SetCoin(0);
        //  coins = 0;
        PrefInfo408.SetChapter(1);
        var health = UIManager408.Instance.GetPanel<MainGame408>().cPlayer408.GetComponent<Health408>();
        health.health = 3;
        ResetAllStatsObject();
        RefreshLevel();
        maps[0].gameObject.SetActive(true);
        PrefInfo408.SetChapter(1);
    }


    private void RefreshLevel()
    {
        var ReactiveObject = UIManager408.Instance.GetPanel<MainGame408>().gameObjectInChapter;

        foreach (var o in ReactiveObject)
        {
            o.gameObject.SetActive(true);
        }

        ResetAllStatsObject();
    }


    private void ResetAllStatsObject()
    {
        foreach (var VARIABLE in UIManager408.Instance.GetPanel<MainGame408>().health)
        {
            if (VARIABLE.CompareTag("GroundMonster"))
                VARIABLE.health = 2;
            else if (VARIABLE.CompareTag("FlyMonster"))

                VARIABLE.health = 1;
        }
    }

    public void ContinueGame()
    {
        coins = PrefInfo408.GetCoin();
        var health = UIManager408.Instance.GetPanel<MainGame408>().cPlayer408.GetComponent<Health408>();
        health.health = PrefInfo408.GetHealth();
        var currentLevel = PrefInfo408.GetChapter();
        maps[currentLevel - 1].gameObject.SetActive(true);
        RefreshLevel();
    }

    [Button]
    private void Test()
    {
        Debug.LogError(PrefInfo408.GetCoin());
    }
}