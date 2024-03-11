using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Xml.Serialization;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MenuController : MonoBehaviour
{


    [SerializeField]
    private Animator _dropDownAnimator;

    [SerializeField]
    private GameObject[] _scrollViewsLessons;

    [SerializeField]
    private TMP_Text[] _leftBarLessonsTexts;

    [SerializeField]
    private TMP_Text[] _leftBarMainTexts;

    [SerializeField]
    private string[] _upNames;

    [SerializeField]
    private VideoClip[] _rigtVideoClips;

    [SerializeField]
    private TMP_Text _upNamesText;

    [SerializeField]
    private VideoPlayer _rightVideoPlayer;


    [SerializeField]
    private Toggle[] _languageToggle;

    private bool _mainDropDown = false;



    public void PressMainButtons(int index)
    {
        DisableLeftBarTexts();


        if (index == 0)
        {
            MainDropDown();
        }

        else if (_mainDropDown)
        {
            MainDropDown();
        }

        if (index == 1)
        {
            ShowFavorites();
        }

        else if (index == 2)
        {
            ShowSettings();
        }

        else if (index == 2)
        {


        }
    }



    public void SelectLessons(int _index)
    {
        DisableLessons();
        DisableLessonsTexts();
        _upNamesText.text = _upNames[_index];
        _rightVideoPlayer.clip = _rigtVideoClips[_index];
        _scrollViewsLessons[_index].SetActive(true);
    }


    public void SelectLanguage(int index)
    {
        DiableAllIsOns();
        //_languageToggle[index].Describe();
    }

    public void DiableAllIsOns()
    {
        for (int i = 0; i < _languageToggle.Length; i++)
        {
            _languageToggle[i].Describe();
        }
    }



    private void ShowSettings()
    {
        DisableLessons();
        _scrollViewsLessons[6].SetActive(true);
    }

    private void ShowFavorites()
    {
        DisableLessons();
        _scrollViewsLessons[4].SetActive(true);
    }

    private void MainDropDown()
    {
        _mainDropDown = !_mainDropDown;

        if (_mainDropDown)
            _dropDownAnimator.SetInteger("MainDrop", 1); // ochilishi
        
        else
            _dropDownAnimator.SetInteger("MainDrop", 0); // yopilishi
    }

    private void DisableLeftBarTexts()
    {
        for (int i = 0; i < _leftBarMainTexts.Length; i++)
        {
            _leftBarMainTexts[i].alpha = 0.6f;
        }
    }

    private void DisableLessonsTexts()
    {
        for (int i = 0; i < _leftBarLessonsTexts.Length; i++)
        {
            _leftBarLessonsTexts[i].alpha = 0.6f;
        }
    }

    void DisableLessons()
    {
        for (int i = 0; i < _scrollViewsLessons.Length; i++)
        {
            _scrollViewsLessons[i].SetActive(false);
        }
    }

}
