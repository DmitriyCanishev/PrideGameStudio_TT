using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    CharacterController MyBodyCamera;
    float moveX, moveY;
    public float SensX = 5, SensY = 10;
    public Vector2 MinMaxY = new Vector2(-40, 40);
    public Vector2 MinMaxX = new Vector2(-360, 360);

    // Start is called before the first frame update
    void Start()
    {
        MyBodyCamera = this.GetComponent<CharacterController>();
    }

    public float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F) angle += 360F;
        if (angle > 360F) angle -= 360F;

        return Mathf.Clamp(angle, min, max);
    }
    // Update is called once per frame
    void Update()
    {
     if(MyBodyCamera != null)
        {
            moveY -= Input.GetAxis("Mouse Y") * SensY;
            moveY = ClampAngle(moveY, MinMaxY.x, MinMaxY.y);

            moveX += Input.GetAxis("Mouse X") * SensX;
            moveX = ClampAngle(moveX, MinMaxX.x, MinMaxX.y);

            MyBodyCamera.transform.rotation = Quaternion.Euler(moveY, moveX, 0);
        }   
    }
}
