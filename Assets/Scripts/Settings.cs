using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Settings")]
public class Settings : ScriptableObject
{
    public GameObject[] platform;
    //public GameObject platform5x5;
    //public GameObject platform10x10;
    //public GameObject platform20x20;
    public GameObject Coin;
    public GameObject Crystal;
   
    public int maxCoinTo5x5;
    [SerializeField]
    public int maxCoinTo10x10;
    [SerializeField]
    public int maxCoinTo20x20;
    [SerializeField]
    public int maxCrystal5x5;
    [SerializeField]
    public int maxCrystal10x10;
    [SerializeField]
    public int maxCrystal20x20;

    //public float speed;
    public int minCoin;
    public int minCrystal;
}
