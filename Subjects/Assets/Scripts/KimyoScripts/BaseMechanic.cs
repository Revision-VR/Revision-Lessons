using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class BaseMechanic : MonoBehaviour
{

    [SerializeField]
    private Transform BgCanvasForParent;


    [SerializeField]
    private BaseMechanic _baseMechanicFirst;

    [SerializeField]
    private BaseMechanic _baseMechanicSecond;

    [SerializeField]
    private Vector3 _scaleWhenSmall;

    [SerializeField]
    private Vector3 _scaleWhenBig;


    private Quaternion _rotation;


    private void Start()
    {
        _rotation = gameObject.transform.localRotation;
    }


    private void OnMouseDown()
    {
        MoveToCentre();
    }


    public void MoveToCentre()
    {
        if (transform.parent == null)
            return;


        _baseMechanicFirst.OnLeftReset(transform.position);
        _baseMechanicSecond.OnLeftReset(transform.position);


        gameObject.transform.parent = null;
        gameObject.transform.position = Vector3.zero;
        gameObject.transform.localScale = _scaleWhenBig;
    }


    public void OnLeftReset(Vector3 pos)
    {
        if (gameObject.transform.parent != null)
            return;
        

        gameObject.transform.parent = BgCanvasForParent;
        gameObject.transform.localRotation = _rotation;
        gameObject.transform.position = pos;
        gameObject.transform.localScale = _scaleWhenSmall;

    }


}
