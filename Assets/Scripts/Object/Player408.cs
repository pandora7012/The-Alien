using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player408 : MonoBehaviour
{
    public Animator anim;
    [SerializeField] private Controller408 controller; // 플레이어 컨트롤러
    [SerializeField] private Health408 health; // 체력
    private bool _isUnstoppable; // 무적 상태인지 아닌지
    [SerializeField] private Animator animator;

    private void Update()
    {
        controller.Controlling(); 
        animator.SetFloat("Velocity" , GetComponent<Rigidbody2D>().velocity.x);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag($"Damageable"))
        {
            if (_isUnstoppable) return; // 무적 상태라면 데미지를 입지 않는다.
            health.TakeDamage(1); 
            StartUnstoppableState();
        }
    }

    private IEnumerator ToGoUnstoppableState()
    {
        _isUnstoppable = true;
        yield return new WaitForSeconds(3f); // 3초간 무적 상태
        _isUnstoppable = false;
    }
    
    private void StartUnstoppableState()
    {
        StartCoroutine(ToGoUnstoppableState());
    }
    
    
}
