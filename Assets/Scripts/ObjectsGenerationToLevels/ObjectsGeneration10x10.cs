using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsGeneration10x10 : MonoBehaviour
{
    public Settings settings;
    CoinCollect count;

    void Start()
    {

        if (settings.platform[1])
        {
            for (int i = Random.Range(1, 30); i < settings.maxCoinTo10x10; i++)
            {
                float addXPos = Random.Range(-10f, 10f);
                float addZPos = Random.Range(-10f, 10f);
                Vector3 spawnPos = transform.position + new Vector3(addXPos, 1, addZPos);

                Instantiate(settings.Coin, spawnPos, Quaternion.identity);
            }

            for (int i = 0; i < settings.maxCrystal10x10; i++)
            {
                float addXPos = Random.Range(-10f, 10f);
                float addZPos = Random.Range(-10f, 10f);
                Vector3 spawnPos = transform.position + new Vector3(addXPos, 1, addZPos);

                Instantiate(settings.Crystal, spawnPos, Quaternion.identity);
            }

        }


    }

}



