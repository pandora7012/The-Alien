using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class Health408 : MonoBehaviour
{
    public int health = 3;
    public int maxHealth;
    [SerializeField] Image healthVisualize;

    
    [Button]
    public void TakeDamage(int damage)
    {
        health -= damage;
        VisualUpdate();
        if (health > 0) return;
        health = 0;
        OnDie();
    }

    private void OnDie()
    {
        gameObject.SetActive(false);
    }

    private void VisualUpdate()
    {
        healthVisualize.fillAmount = (float)health / maxHealth;
    }
    
}
