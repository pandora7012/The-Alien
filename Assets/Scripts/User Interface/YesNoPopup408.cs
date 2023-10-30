using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesNoPopup408 : Panel408
{

    public Utilities.Task TaskOnYes; 
    
    
    public override void OnShow()
    {
        base.OnShow();
        Time.timeScale = 0;
    }

    public void OnYes()
    {
        TaskOnYes?.Invoke();
        Time.timeScale = 1;
    }

    public void OnNo()
    {
        Time.timeScale = 1;
    }
}
