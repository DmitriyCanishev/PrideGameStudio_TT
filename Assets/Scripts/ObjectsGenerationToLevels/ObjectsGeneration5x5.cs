using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectsGeneration5x5 : MonoBehaviour
{
    public Settings settings;

    void Start()
    {

        if (settings.platform[0])
        {

            for (int i = Random.Range(1, 9); i < settings.maxCoinTo5x5; i++)
            {
                float addXPos = Random.Range(-5f, 5f);
                float addZPos = Random.Range(-5f, 5f);
                Vector3 spawnPos = transform.position + new Vector3(addXPos, 1, addZPos);
               
                Instantiate(settings.Coin, spawnPos, Quaternion.identity);

            }

            for (int i = 0; i < settings.maxCrystal5x5; i++)
            {
                float addXPos = Random.Range(-5f, 5f);
                float addZPos = Random.Range(-5f, 5f);
                Vector3 spawnPos = transform.position + new Vector3(addXPos, 1, addZPos);

                Instantiate(settings.Crystal, spawnPos, Quaternion.identity);

            }
        }

    }

}



