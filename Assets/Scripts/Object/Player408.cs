using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player408 : MonoBehaviour
{
    [SerializeField] private Controller408 controller; 
    [SerializeField] private Health408 health;
    private bool isUnstoppable; 


    private void Update()
    {
        controller.Controlling();
        GetComponent<Animator>().SetFloat("Velocity",
            GetComponent<Rigidbody2D>().velocity.x);
    }


    private IEnumerator UnstoppableState()
    {
        isUnstoppable = true;
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(3f); 
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        isUnstoppable = false;
    }

    private void StartUnstoppable()
    {
        StartCoroutine(UnstoppableState());
    }

    public void TakeDamage(int damage)
    {
        if (isUnstoppable) return; 
        health.TakeDamage(damage);
        if (health.health <= 0)
        {
            OnDie();
        }
        else
        {
            StartCoroutine(UnstoppableState());
        }
    }

    private void OnDie()
    {
        gameObject.SetActive(false);
        health.OnDie();
        UIManager408.Instance.GetPanel<NotifyPopup408>().OnSetup("Notice", "Game Over");
    }
}