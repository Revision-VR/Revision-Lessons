using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    
    [SerializeField]
    private float RotationSpeed;

    [SerializeField]
    private float _moveSpeed = 15f;


    public GameObject _humanModel;

    public GameObject _transformModel;


    public Vector3 vec;

    private Quaternion _moveRotation;


    float _inputPosX;
    float _inputPosY;

    float _inputRotateX;
    float _inputRotateY;

    public float repeatSpeed = 1f; // Speed of repeated movement
    private Vector3 lastMousePosition; // Last recorded mouse position

    bool firstIgnor = false;

    void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            _inputRotateX += Input.GetAxis("Mouse X") * RotationSpeed;
            _inputRotateY += Input.GetAxis("Mouse Y") * RotationSpeed;

            _humanModel.transform.localRotation = Quaternion.Euler(-_inputRotateY, _inputRotateX, 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            _moveRotation = _humanModel.transform.rotation;
        }




        if (Input.GetMouseButtonDown(1))
        {
            lastMousePosition = Input.mousePosition;
        }

        else if (Input.GetMouseButton(1))
        {
            Vector3 movement = (Input.mousePosition - lastMousePosition) * repeatSpeed * Time.deltaTime;


            transform.Translate(-movement);
            lastMousePosition = Input.mousePosition;
        }
    }
}
