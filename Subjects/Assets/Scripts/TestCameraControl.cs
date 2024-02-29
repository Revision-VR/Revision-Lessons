using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCameraControl : MonoBehaviour
{


    float _inputX;
    float _inputY;


    public float speed = 15f;

 
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            print("Axis " + Input.GetAxis("Mouse X"));
            print("Pos " + Input.mousePosition.x);

            _inputX += Input.GetAxis("Mouse X") * speed;
            _inputY += Input.GetAxis("Mouse Y") * speed;
        
            //Camera.main.transform.position = -(new Vector3(_inputX, _inputY, 0));
        }
    }
}
