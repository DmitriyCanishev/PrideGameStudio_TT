using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    private Text coinCounter;
    ObjectsGeneration5x5 Money;
    static public int money;


    void Start()
    {
       coinCounter = this.GetComponent<Text>();
       
       money = 0;
    }

    void Update()
    {
        coinCounter.text = money.ToString();
    }

}
