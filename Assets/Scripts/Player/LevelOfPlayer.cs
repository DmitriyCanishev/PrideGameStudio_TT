using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelOfPlayer : MonoBehaviour
{
    public int curEXP = 0;
    public int maxEXP = 3;
    public int level = 1;

    public Text Level;
    // Start is called before the first frame update
    void Start()
    {
        Level = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        if (maxEXP < curEXP) curEXP = maxEXP;
        if (curEXP < 0) curEXP = 0;
        if(curEXP == maxEXP)
        {
            curEXP = 0;
            maxEXP = maxEXP + 3;
            level++;
            Level.text = level.ToString();
        }
    }

}
