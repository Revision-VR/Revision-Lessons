using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoveButton : MonoBehaviour
{


    [SerializeField]
    private GameObject _colliderObject;


    [SerializeField]
    private GameObject _planetObject;


    [SerializeField]
    private FallingIntoPlace[] _fallingIntoPlace;


    private MouseMoveObject _mouseMoveObject;
    private Animator _animatorModel;
    private LungAnimScriptController _animScriptController;


    private CameraControl controlScript;
    private GameObject _bgSelectedObject;
    private bool _isTrunOnOff;


    private void Start()
    {
        controlScript = Camera.main.gameObject.GetComponent<CameraControl>();

        _mouseMoveObject = _planetObject.GetComponent<MouseMoveObject>();
        _animatorModel = _planetObject.GetComponent<Animator>();
        _animScriptController = _planetObject.GetComponent<LungAnimScriptController>();

    }


    public void OnPressMoveButton(GameObject bgSelected)
    {
        if (!_animScriptController.canMove)
        {
            return;
        }

        if (_isTrunOnOff)
            TurnOff();
        else
            TurnOn();


        _bgSelectedObject = bgSelected;
        _bgSelectedObject.SetActive(!_isTrunOnOff);
        _isTrunOnOff = !_isTrunOnOff;
    }
        
    public void OffMoveFunction()
    {
        _bgSelectedObject.SetActive(false);
        _mouseMoveObject.enabled = false;
    }

    public void ResetAllObject()
    {
        for (int i = 0; i < _fallingIntoPlace.Length; i++)
        {
            _fallingIntoPlace[i].ResetPosition();
            _fallingIntoPlace[i].inSide = false;
        }
    }

    private void TurnOff()
    {
        _mouseMoveObject.enabled = false;
        controlScript.enabled = true;
        _colliderObject.SetActive(false);
        _animatorModel.enabled = true;

        for (int i = 0; i < _fallingIntoPlace.Length; i++)
        {
            _fallingIntoPlace[i]._mouseDown = false;
            _fallingIntoPlace[i].firstIgnor = false;
        }

        ResetAllObject();
    }

    private void TurnOn()
    {
        _mouseMoveObject.enabled = true;
        controlScript.enabled = false;
        _colliderObject.SetActive(true);
        _animatorModel.enabled = false;

        for (int i = 0; i < _fallingIntoPlace.Length; i++)
        {
            _fallingIntoPlace[i]._mouseDown = true;
        }

    }


}
