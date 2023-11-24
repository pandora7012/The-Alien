using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class YesNoPopup408 : Panel408
{
    private Utilities.Task TaskOnYes;

    [SerializeField] private TextMeshProUGUI title;
    [SerializeField] private TextMeshProUGUI mess;


    public override void OnShow()
    {
        base.OnShow();
        Time.timeScale = 0;
    }


    public void OnSetup(string tittle, string message, Utilities.Task task)
    {
        gameObject.SetActive(true);
        title.text = tittle;
        mess.text = message;
        TaskOnYes = task; 
    }

    public void OnClickYes()
    {
        TaskOnYes?.Invoke();
        Time.timeScale = 1;
        OnHide();
    }

    public override void OnHide()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}