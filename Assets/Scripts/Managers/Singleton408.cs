using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton408<T> : MonoBehaviour where T : Singleton408<T>
{
    public static T Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this as T;
            OnInit();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    protected virtual void OnInit(){}
}
