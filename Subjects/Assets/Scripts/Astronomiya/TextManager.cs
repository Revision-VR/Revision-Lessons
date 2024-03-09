using UnityEngine;
using TMPro;


public class TextManager : MonoBehaviour
{


    #region Singleton

    private static TextManager _instance;

    public static TextManager Instance 
    {
        get 
        { 
            return _instance;
        } 
    }

    private void Awake()
    {
        _instance = this; 
    }
    #endregion


    public TMP_Text ChangableInfo;


}
