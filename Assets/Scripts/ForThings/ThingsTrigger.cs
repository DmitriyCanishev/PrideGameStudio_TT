using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ThingsTrigger : MonoBehaviour
{

    //отвечает за отображение объекта
    Renderer MyMesh;
    public Material On, Off;

    public string Name;
    public bool visible = true;
    SelectObjectOnScene text;
    public LevelOfPlayer level;



    //выделен объект или нет
    public bool SelectedObject = false;

    void Start()
    {
        MyMesh = this.GetComponent<Renderer>();
    }

    void Update()
    {
        if (visible == false)
        {
            Destroy(this.gameObject);          
        }

        if (SelectedObject)
        {
            MyMesh.material = On;
        }
        else
        {
            MyMesh.material = Off;
        }
    }

    void OnTriggerEnter(Collider col)
    {
       
        CoinCollect.money += 1;
        CrystalCollect.crystal += 1;
    }


}
