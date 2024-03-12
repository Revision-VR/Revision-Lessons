using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    [SerializeField]
    private float RotationSpeed;

    public GameObject _cameraParent;


    float _inputRotateX;
    float _inputRotateY;

    public float repeatSpeed = 1f; // Speed of repeated movement
    private Vector3 lastMousePosition; // Last recorded mouse position



    private void Start()
    {
        _inputRotateX = _cameraParent.transform.localEulerAngles.y;
        _inputRotateY = -(_cameraParent.transform.localEulerAngles.x);
    }


    void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            _inputRotateX += Input.GetAxis("Mouse X") * RotationSpeed;
            _inputRotateY += Input.GetAxis("Mouse Y") * RotationSpeed;

            _cameraParent.transform.localRotation = Quaternion.Euler(-_inputRotateY, _inputRotateX, 0);
        }






        if (Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
            lastMousePosition = Input.mousePosition;
        }

        else if (Input.GetMouseButton(1) || Input.GetMouseButton(2))
        {
            Vector3 movement = (Input.mousePosition - lastMousePosition) * repeatSpeed * Time.deltaTime;

            transform.Translate(-movement);
            lastMousePosition = Input.mousePosition;
        }


    }
}
