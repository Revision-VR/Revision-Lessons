using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourcesMenu : MonoBehaviour
{

    #region
    private static ResourcesMenu _instance;

    public static ResourcesMenu Instance
    {
        get { return _instance; }
    }


    private void Awake()
    {
        _instance = this;
    }
    #endregion


    public Texture _chosenTrueTexture;


}
