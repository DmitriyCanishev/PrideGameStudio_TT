using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalCollect : MonoBehaviour
{
    private Text crystalCounter;
    
    static public int crystal;
       
    void Start()
    {
        crystalCounter = this.GetComponent<Text>();
        crystal = 0;
    }

    void Update()
    {
        crystalCounter.text = crystal.ToString();
    }

}
