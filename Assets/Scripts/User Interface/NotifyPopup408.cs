using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NotifyPopup408 : Panel408
{
    
    private Utilities.Task task;
    private TextMeshProUGUI messageText;
    
    public override void OnShow()
    {
        base.OnShow();
    }
    
    public override void OnHide()
    {
        base.OnHide();
        task?.Invoke();
    }
    
    public void Init(string text, Utilities.Task task)
    {
        this.task = task;
        messageText.text = text;
    }
    
    
}
