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

    private GameObject ParentGameObjec;

    private void Start()
    {
        _chosenButtons = GetComponent<Button>(); 
        _image = GetComponent<RawImage>();
        ParentGameObjec = gameObject.transform.parent.gameObject;

        _chosenFalseTexture = _image.texture;

        _chosenButtons.onClick.AddListener(() => PressChosen());
    }


    void PressChosen()
    {
        isChosen = !isChosen;

        if (isChosen && !ParentGameObjec.name.EndsWith(')'))
        {
            _image.texture = FavoritesMenu.Instance._chosenTrueTexture;
            FavoritesMenu.Instance.ShowSortedCards(ParentGameObjec);
        }
        else
        {
            _image.texture = FavoritesMenu.Instance._chosenFalseTexture;
            FavoritesMenu.Instance.HideSortedCards(ParentGameObjec);
        }
    }
}
