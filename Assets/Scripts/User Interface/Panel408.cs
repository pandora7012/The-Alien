using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Utilities;

public class Panel408 : MonoBehaviour
{
    private Task task;
    private TextMeshProUGUI messageText; 
    
    public virtual void OnCreate()
    {
        
    }

    public virtual void OnShow()
    {
        
    }

    public void Init(string text, Task task)
    {
        this.task = task;
        messageText.text = text;
    }

    public void OnClose()
    {
        if (task != null)
            task.Invoke();
        gameObject.SetActive(false);
    }


    
    
}
