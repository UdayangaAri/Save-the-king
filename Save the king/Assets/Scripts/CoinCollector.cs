using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public static CoinCollector instance;
    public TextMeshProUGUI text;
    int score;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text =  score.ToString();
    }
}
