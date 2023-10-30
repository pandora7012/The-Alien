    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager408 : Singleton408<GameManager408>
{
    public int coins;
    public GameObject[] maps; 
    
    public void AddCoins(int amount)
    {
        coins += amount;
        PrefInfo408.SetCoin(coins);
        
    }

    public void RemoveCoins(int amount)
    {
        coins -= amount;
        PrefInfo408.SetCoin(coins);
        
    }


    public void NextChapter()
    {
        Debug.LogError("NEXT CHAPTER");
    }
    
    public void GetToChapter(int level)
    {
        
    }

    public void ChapterComplete()
    {
        SceneManager.LoadScene(PrefInfo408.GetChapter());
    }
    
    
}
