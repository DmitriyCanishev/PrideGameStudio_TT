using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObjectOnScene : MonoBehaviour
{

    Camera camera;
    ObjectsGeneration5x5 Count;
    public GameObject button_text_coin;
    public GameObject button_text_crystal;

    float legth = 1.5f;
    public string UnSelectObject = "Things";
    //public string UnSelectCrystal = "Crystal";

    // Start is called before the first frame update
    void Start()
    {
        camera = this.GetComponent<Camera>();

    }

    void UnSelectAll()
    {
        GameObject[] ListObjects = GameObject.FindGameObjectsWithTag(UnSelectObject);

        for (int i = 0; i < ListObjects.Length; i++)
        {
            ThingsTrigger myObjct = ListObjects[i].GetComponent<ThingsTrigger>();
            myObjct.SelectedObject = false; ;

        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lineOrigin = camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));

        Vector3 endLine = camera.transform.forward * legth; ;

        Debug.DrawLine(lineOrigin, endLine, Color.red);

        //создание прямой от началальной точки и окончания луча
        Ray ray = new Ray(lineOrigin, endLine);

        RaycastHit hit = new RaycastHit();

        UnSelectAll();
        //проверяем с кем столкнулись
        if(Physics.Raycast(ray, out hit, legth))
        {

            ThingsTrigger myObjct = hit.collider.GetComponent<ThingsTrigger>();

            if(myObjct != null)
            {
                //Debug.Log(myObjct.Name);
                myObjct.SelectedObject = true;

                switch (myObjct.Name)
                {
                    case "Coin":
                        button_text_coin.SetActive(true);
                        if (Input.GetKey(KeyCode.R))
                        {     
                            myObjct.visible = false;
                            button_text_coin.SetActive(false);
                            

                        }
                    
                        break;

                    case "Crystal":
                        button_text_crystal.SetActive(true);
                        if (Input.GetKey(KeyCode.C))
                        {
                            myObjct.visible = false;
                            button_text_crystal.SetActive(false);
                            
                        }
                        break;
                }
            }
        }

    }


}
