using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTheme : MonoBehaviour
{

    [SerializeField] private RawImage[] _icons;
    [SerializeField] private Texture[] _darkIcons;
    [SerializeField] private Texture[] _lightIcons;

    [SerializeField] private TMP_Text[] _texts;

    [SerializeField] private Image[] _images;


    [SerializeField] private Image _searchMenu;
    [SerializeField] private RawImage _userMenu;


    [SerializeField] private RawImage _subjectsViewRawImage;


    [SerializeField] private Texture _lightSubjectsViewTexture;
    [SerializeField] private Texture _darkSubjectsViewTexture;


    [SerializeField] private GameObject _lightBg;
    [SerializeField] private GameObject _darkBg;


    [SerializeField] private GameObject _favoriteParentObject;

    private bool isDark = true;
    
    public void ChangeThemeButton()
    {
        if (isDark)
        {
            ChangeThemeToDark();
        }
        else
        {
            ChangeThemeToWhite();
        }

        isDark = !isDark;
    }


    void ChangeThemeToDark()
    {
        _subjectsViewRawImage.texture = _darkSubjectsViewTexture;


        _userMenu.color = new Color32(30, 42, 57, 255);
        _searchMenu.color = new Color32(15, 28, 44, 255);


        _darkBg.SetActive(true);
        _lightBg.SetActive(false);

        for (int i = 0; i < _images.Length; i++)
        {
            _images[i].color = new Color32(47, 75, 109, 255);
        }

        for (int i = 0; i < _icons.Length; i++)
        {
            _icons[i].texture = _darkIcons[i];
        }

        for (int i = 0; i < _texts.Length; i++) 
        {
            _texts[i].color = new Color32(171, 206, 249, 255);
        }

        ChangeFavorites(new Color32(47, 75, 109, 255));

    }


    void ChangeThemeToWhite()
    {

        _subjectsViewRawImage.texture = _lightSubjectsViewTexture;



        _userMenu.color = new Color32(255, 255, 255, 255);
        _searchMenu.color = new Color32(253, 232, 228, 255);


        _lightBg.SetActive(true);
        _darkBg.SetActive(false);

        for (int i = 0; i < _images.Length; i++)
        {
            _images[i].color = new Color32(210, 116, 100, 255);
        }

        for (int i = 0; i < _icons.Length; i++)
        {
            _icons[i].texture = _lightIcons[i];
        }

        for (int i = 0; i < _texts.Length; i++)
        {
            _texts[i].color = new Color32(50, 50, 50, 255);
        }

        ChangeFavorites(new Color32(210, 116, 100, 255));

    }


    void ChangeFavorites(Color32 _color)
    {
        for (int i = 0; i < _favoriteParentObject.transform.childCount; i++)
        {
            _favoriteParentObject.transform.GetChild(i).transform.GetChild(0).GetComponent<Image>().color = _color;
        }
    }


}
