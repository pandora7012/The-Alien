using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainGame408 : Panel408
{
    [SerializeField] private Image[] healthVisualize;
    public Player408 cPlayer408; // 플레이어
    [SerializeField] private TextMeshProUGUI capsuleText;

    public GameObject[] gameObjectInChapter;
    public Health408[] health; 
 
    public override void OnShow()
    {
        base.OnShow();
        Time.timeScale = 1;
    }


    public void OnSetup()
    {
        capsuleText.text = (PrefInfo408.GetChapter() - 1).ToString(); // 캡슐 텍스트
        cPlayer408.gameObject.SetActive((true));
        cPlayer408.transform.position = Vector2.zero;
        cPlayer408.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        gameObject.SetActive(true);

        OnRefresh();
    }

    public void OnRefresh()
    {
        var health = cPlayer408.GetComponent<Health408>().health;
        for (int i = 0; i < healthVisualize.Length; i++)
        {
            healthVisualize[i].gameObject.SetActive(i < health);
        }
    }


    public void OnUpgradeClick()
    {
        AudioManager408.Instance.PlaySound(0, 1);
        var settingPopup = UIManager408.Instance.GetPanel<UpgradeUI408>();
        settingPopup.OnSetup();
    }

    public void OnSettingClick()
    {
        AudioManager408.Instance.PlaySound(0, 1);

        var settingPopup = UIManager408.Instance.GetPanel<SettingPopup408>();
        settingPopup.OnShow();
    }
}