using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager408 : Singleton408<UpgradeManager408>
{
    public  UpgradeData408 healthData;
    public  UpgradeData408 speedData;
    public  UpgradeData408 jumpData;


    public void SaveUpgradeData()
    {
        var ui = UIManager408.Instance.GetPanel<UpgradeUI408>();
        PrefInfo408.SetHealthLevel(ui.healthLevel);
        PrefInfo408.SetSpeedLevel(ui.speedLevel);
        PrefInfo408.SetJumpPowerLevel(ui.jumpLevel);
    }


    public float GetSpeedValue()
    {
        var ui = UIManager408.Instance.GetPanel<UpgradeUI408>();
        return speedData.values[ui.speedLevel] / (4 + ui.speedLevel/2);
    }

    public float GetJumpValue()
    {
        var ui = UIManager408.Instance.GetPanel<UpgradeUI408>();
        return jumpData.values[ui.jumpLevel] / (2+ ui.jumpLevel/1.5f);
    }

   
    
    
    
}
