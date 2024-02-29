using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    [SerializeField]
    private float RotationSpeed;

    [SerializeField]
    private GameObject _humanModel;



    private Vector3 _origin;
    private Vector3 _diffrence;
    private Vector3 _resetCamera;


    private bool drag = false;

    private Transform dragging;
    private Vector3 offset;

    private bool canRotate;



    private Vector3 dragOrigin;

    void Start()
    {
        _resetCamera = Camera.main.transform.position;
    }


    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            canRotate = true;
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            canRotate = false;
            dragging = null;
        }

        if (canRotate)
        {
            _humanModel.transform.Rotate(Input.GetAxis("Mouse Y") * RotationSpeed * Time.deltaTime, -(Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime), 0);
        }

        if (dragging != null)
        {
            dragging.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - offset);
        }
    }
}
