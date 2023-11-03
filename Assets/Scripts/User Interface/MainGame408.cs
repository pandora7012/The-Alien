using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame408 : Panel408
{
       public override void OnShow()
        {
            base.OnShow();
            Time.timeScale = 1;
        }
       
        public void SettingBtn()
        {
            var settingPopup = UIManager408.Instance.GetPanel<SettingPopup408>();
            settingPopup.OnShow();
        }
        
        public void UpgradeBtn()
        {
            var settingPopup = UIManager408.Instance.GetPanel<UpgradeUI408>();
            settingPopup.OnShow();
        }
        
        
        
        
        
        
}
