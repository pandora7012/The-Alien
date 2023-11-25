using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeUI408 : Panel408
{
    [SerializeField] private TextMeshProUGUI currentCoins, healthCoinText, speedCoinText, jumpCoinText;

    [SerializeField] private RectTransform healthBar, speedBar, jumpBar;
    public int healthLevel = -1, speedLevel = -1, jumpLevel = -1;
    public int forResetHP, forResetSpeed = -1, forResetJump = -1;

    [SerializeField] private int fakeCoins;

    [SerializeField] private int pixelPerUpgrade;
    [SerializeField] private Button healthBtn, speedBtn, jumpBtn;

    private bool openFirstTime; 

    public override void OnShow()
    {
        base.OnShow();
        Time.timeScale = 0;
    }


    [Button]
    public void OnSetup()
    {
        OnShow();
        Time.timeScale = 0; 
        currentCoins.text = GameManager408.Instance.coins.ToString();
        fakeCoins = GameManager408.Instance.coins;
        if (PrefInfo408.GetChapter() >= 1 && !openFirstTime)
        {
            healthLevel = PrefInfo408.GetHealthLevel();
            speedLevel = PrefInfo408.GetSpeedLevel();
            jumpLevel = PrefInfo408.GetJumpPowerLevel();
            openFirstTime = true;
        }

        forResetJump = healthLevel;
        forResetSpeed = speedLevel;
        forResetHP = jumpLevel;


        healthBar.sizeDelta = new Vector2(healthLevel * pixelPerUpgrade, healthBar.sizeDelta.y);
        speedBar.sizeDelta = new Vector2(speedLevel * pixelPerUpgrade, speedBar.sizeDelta.y);
        jumpBar.sizeDelta = new Vector2(jumpLevel * pixelPerUpgrade, jumpBar.sizeDelta.y);

        healthCoinText.text = healthLevel + 1 >= UpgradeManager408.Instance.healthData.prices.Count
            ? "Maximum level reached"
            : UpgradeManager408.Instance.healthData.prices[healthLevel + 1].ToString();

        speedCoinText.text = speedLevel + 1 >= UpgradeManager408.Instance.speedData.prices.Count
            ? "Maximum level reached"
            : UpgradeManager408.Instance.speedData.prices[speedLevel + 1].ToString();

        jumpCoinText.text = jumpLevel + 1 >= UpgradeManager408.Instance.jumpData.prices.Count
            ? "Maximum level reached"
            : UpgradeManager408.Instance.jumpData.prices[jumpLevel + 1].ToString();

        healthBtn.interactable = healthLevel + 1 < UpgradeManager408.Instance.healthData.values.Count;
        speedBtn.interactable = speedLevel + 1 < UpgradeManager408.Instance.speedData.values.Count;
        jumpBtn.interactable = jumpLevel + 1 < UpgradeManager408.Instance.jumpData.values.Count;
        
        currentCoins.text = fakeCoins.ToString();
        
    }

    public void OnSave()
    {

        AudioManager408.Instance.PlaySound(0, 1);
        forResetJump = healthLevel;
        forResetSpeed = speedLevel;
        forResetHP = jumpLevel;

        GameManager408.Instance.coins = fakeCoins;
    }

    public void OnReset()
    {

        AudioManager408.Instance.PlaySound(0, 1);
        healthLevel = forResetHP;
        speedLevel = forResetSpeed;
        jumpLevel = forResetJump;
        OnSetup();
    }

    public void OnUpgradeHealth()
    {
        if (fakeCoins < UpgradeManager408.Instance.healthData.prices[healthLevel + 1])
        {
            UIManager408.Instance.GetPanel<NotifyPopup408>().OnSetup("Notice", "You don’t have enough coin");
        }
        else
        {
            healthLevel += 1;
            fakeCoins -= UpgradeManager408.Instance.healthData.prices[healthLevel];
            healthBar.sizeDelta = new Vector2(healthLevel * pixelPerUpgrade, healthBar.sizeDelta.y);
            healthCoinText.text = healthLevel + 1 >= UpgradeManager408.Instance.healthData.prices.Count
                ? "Maximum level reached"
                : UpgradeManager408.Instance.healthData.prices[healthLevel + 1].ToString();
        }
        healthBtn.interactable = healthLevel + 1 < UpgradeManager408.Instance.healthData.values.Count;
        currentCoins.text = fakeCoins.ToString();
    }

    public void OnUpgradeSpeed()
    {
        if (fakeCoins < UpgradeManager408.Instance.speedData.prices[speedLevel + 1])
        {
            UIManager408.Instance.GetPanel<NotifyPopup408>().OnSetup("Notice", "You don’t have enough coin");
        }
        else
        {
            speedLevel += 1;
            fakeCoins -= UpgradeManager408.Instance.speedData.prices[speedLevel];
            speedBar.sizeDelta = new Vector2(speedLevel * pixelPerUpgrade, speedBar.sizeDelta.y);
            speedCoinText.text = speedLevel + 1 >= UpgradeManager408.Instance.speedData.prices.Count
                ? "Maximum level reached"
                : UpgradeManager408.Instance.speedData.prices[speedLevel + 1].ToString();
        }
        
        speedBtn.interactable = speedLevel + 1 < UpgradeManager408.Instance.speedData.values.Count;
        currentCoins.text = fakeCoins.ToString();
    }

    public void OnUpgradeJump()
    {
        if (fakeCoins < UpgradeManager408.Instance.jumpData.prices[jumpLevel + 1])
        {
            UIManager408.Instance.GetPanel<NotifyPopup408>().OnSetup("Notice", "You don’t have enough coin");
        }
        else
        {
            jumpLevel += 1;
            fakeCoins -= UpgradeManager408.Instance.jumpData.prices[jumpLevel];
            jumpBar.sizeDelta = new Vector2(jumpLevel * pixelPerUpgrade, jumpBar.sizeDelta.y);
            jumpCoinText.text = jumpLevel + 1 >= UpgradeManager408.Instance.jumpData.prices.Count
                ? "Maximum level reached"
                : UpgradeManager408.Instance.jumpData.prices[jumpLevel + 1].ToString();
        }
        jumpBtn.interactable = jumpLevel + 1 < UpgradeManager408.Instance.jumpData.values.Count;
        currentCoins.text = fakeCoins.ToString();
    }

    public override void OnHide()
    {
        base.OnHide();
        Time.timeScale = 1;
    }
}