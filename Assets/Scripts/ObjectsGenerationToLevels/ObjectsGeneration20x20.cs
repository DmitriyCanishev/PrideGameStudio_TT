using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsGeneration20x20 : MonoBehaviour
{
    public Settings settings;

    void Start()
    {
        
        if (settings.platform[2])
        {
            for (int i = Random.Range(1, 50); i < settings.maxCoinTo20x20; i++)
            {
                float addXPos = Random.Range(-20f, 20f);
                float addZPos = Random.Range(-20f, 20f);
                Vector3 spawnPos = transform.position + new Vector3(addXPos, 1, addZPos);

                Instantiate(settings.Coin, spawnPos, Quaternion.identity);
            }

            for (int i = 0; i < settings.maxCrystal20x20; i++)
            {
                float addXPos = Random.Range(-20f, 20f);
                float addZPos = Random.Range(-20f, 20f);
                Vector3 spawnPos = transform.position + new Vector3(addXPos, 1, addZPos);

                Instantiate(settings.Crystal, spawnPos, Quaternion.identity);
            }

        }

    }

}



