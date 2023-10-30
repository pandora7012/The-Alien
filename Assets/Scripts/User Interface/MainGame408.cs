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
    
        public void OnPause()
        {
            Time.timeScale = 0;
        }

        public void SettingBtn()
        {
            
        }
        
        public void UpgradeBtn()
        {
            
        }
        
        
        
        
}
