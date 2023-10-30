using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class UIManager408 : Singleton408<UIManager408>
{
    
    [SerializeField] private List<Panel408> panels;
    
    public T GetPanel<T>() where T : Panel408
    {
        var panel = panels.Find(x => x is T) as T;
        return panel != null ? panel : null;
    }

    
}
