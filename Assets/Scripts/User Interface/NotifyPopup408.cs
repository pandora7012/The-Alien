using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NotifyPopup408 : Panel408
{
    [SerializeField] private TextMeshProUGUI messageText;
    [SerializeField] private TextMeshProUGUI tittleText;

    public override void OnShow()
    {
        base.OnShow();
    }

    public override void OnHide()
    {
        base.OnHide();
        switch (messageText.text)
        {
            case "Congratulations!":
                //  GameManager408.Instance.OnGameWin();
                break;
            case "Game Over":
                GameManager408.Instance.OnGameOver();   
                break;
            case "You have collected energy capsules on this map":
                GameManager408.Instance.NextChapter();
                break; 
        }
    }

    public void OnSetup(string tittle, string message)
    {
        gameObject.SetActive(true);
        messageText.text = message;
        tittleText.text = tittle;
    }
}