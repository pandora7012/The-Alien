using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager408 : Singleton408<GameManager408>
{
    public int coins;
    
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

    }
    
    
}
