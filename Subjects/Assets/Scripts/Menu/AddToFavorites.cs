using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Net.NetworkInformation;

public class AddToFavorites : MonoBehaviour
{

    private Button _chosenButtons;
    private RawImage _image;

    private Texture _chosenFalseTexture;

    bool isChosen = false;

    private void Start()
    {
        _chosenButtons = GetComponent<Button>(); 
        _image = GetComponent<RawImage>();


        _chosenFalseTexture = _image.texture;

        _chosenButtons.onClick.AddListener(() => PressChosen());
    }


    void PressChosen()
    {
        isChosen = !isChosen;

        if (isChosen)
        {
            _image.texture = ResourcesMenu.Instance._chosenTrueTexture;
        }
        else
        {
            _image.texture = _chosenFalseTexture;
        }


    }
}
