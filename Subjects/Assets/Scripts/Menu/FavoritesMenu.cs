using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FavoritesMenu : MonoBehaviour
{

    #region
    private static FavoritesMenu _instance;

    public static FavoritesMenu Instance
    {
        get { return _instance; }
    }


    private void Awake()
    {
        _instance = this;
    }
    #endregion


    public Texture _chosenTrueTexture;
    public Texture _chosenFalseTexture;


    [SerializeField]
    private GameObject _parentObject;

    public void ShowSortedCards(GameObject obj)
    {
        Instantiate(obj, _parentObject.transform);
    }

    public void HideSortedCards(GameObject obj)
    {
        for (int i = 0; i < _parentObject.transform.childCount; i++)
        {
            if (obj.name.EndsWith(')'))
            {
                if (_parentObject.transform.GetChild(i).name == obj.name)
                {
                    Destroy(_parentObject.transform.GetChild(i).gameObject);
                }
            }
            else
            {
                if (_parentObject.transform.GetChild(i).name == obj.name + "(Clone)")
                {
                    Destroy(_parentObject.transform.GetChild(i).gameObject);
                }
            }
        }
    }

}
