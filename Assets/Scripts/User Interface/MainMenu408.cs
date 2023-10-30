using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu408 : Panel408
{
    public override void OnShow()
    {
        base.OnShow();
    }

    public override void OnHide()
    {
        
    }

    public void OnPlayBtn()
    {
        var mainGameUI = UIManager408.Instance.GetPanel<MainMenu408>();
        this.OnHide();
    }

    public void ContinueBtn()
    {
        if (PrefInfo408.GetChapter() is 0)
            UIManager408.Instance.GetPanel<NotifyPopup408>().OnShow();
        else 
            UIManager408.Instance.GetPanel<MainGame408>().OnShow();
    }
    
}
