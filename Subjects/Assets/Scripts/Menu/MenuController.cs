using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class MenuController : MonoBehaviour
{


    [SerializeField]
    private Animator _dropDownAnimator;


    [SerializeField]
    private GameObject[] _scrollViewsLessons;




    bool _mainDropDown = false;

    public void MainDropDown()
    {
        _mainDropDown = !_mainDropDown;

        if (_mainDropDown)
            _dropDownAnimator.SetInteger("MainDrop", 1);
        
        else
            _dropDownAnimator.SetInteger("MainDrop", 0);   
    }


    public void SelectLessons(int _index)
    {
        DisableLessons();
        _scrollViewsLessons[_index].SetActive(true);
    }

    void DisableLessons()
    {
        for (int i = 0; i < _scrollViewsLessons.Length; i++)
        {
            _scrollViewsLessons[i].SetActive(false);
        }
    }

}
