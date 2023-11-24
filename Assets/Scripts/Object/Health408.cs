using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class Health408 : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] Image healthVisualize;

    public void TakeDamage(int damage)
    {
        health -= damage;
        VisualUpdate();
        if (health > 0) return;
        health = 0;
        OnDie();
    }

    public void OnDie()
    {
        if (gameObject.CompareTag("Player"))
            return;
        gameObject.SetActive(false);
    }

    private void VisualUpdate()
    {
        if (gameObject.CompareTag("Player"))
        {
            UIManager408.Instance.GetPanel<MainGame408>().OnRefresh();
        }
        else
        {
            if (gameObject.CompareTag("GroundMonster"))
            {
                healthVisualize.fillAmount =  1 - health / 2f;
            }
            else
            {
                healthVisualize.fillAmount = 1 - health / 1f;
            }
        }
    }
}