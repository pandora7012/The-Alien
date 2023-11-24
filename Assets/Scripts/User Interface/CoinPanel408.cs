using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinPanel408 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;

    public void Update()
    {
        coinText.text = GameManager408.Instance.coins.ToString();
    }
    
}
