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
        base.OnHide();
    }

    public void OnClickStartBtn()
    {
        if (PrefInfo408.GetChapter() is 0)
        {
            GameManager408.Instance.StartNewGame();
            var mainGameUI = UIManager408.Instance.GetPanel<MainGame408>();
            mainGameUI.OnSetup();
            this.OnHide();
        }
        else
        {
            var panel = UIManager408.Instance.GetPanel<YesNoPopup408>();
            panel.OnSetup("Message", "New play will overwrite the old play progress. Continue?",
                () =>
                {
                    GameManager408.Instance.StartNewGame();
                    var mainGameUI = UIManager408.Instance.GetPanel<MainGame408>();
                    mainGameUI.OnSetup();
                    this.OnHide();
                });
        }
    }

    public void OnClickContinueBtn()
    {
        if (PrefInfo408.GetChapter() is 0)
            UIManager408.Instance.GetPanel<NotifyPopup408>().OnSetup("Message", "You have no saved game progress");
        else
        {
            GameManager408.Instance.ContinueGame();
            UIManager408.Instance.GetPanel<MainGame408>().OnSetup();
            OnHide();
        }
    }
}