using System;
using UnityEngine;
using UnityEngine.UIElements;

public class ScrollController : MonoBehaviour
{
    [SerializeField]
    private GameObject GameObject;
    private int count = 1;

   
    public void OnClick()
    {
        //if(count % 2 != 0)
        //{
        //    gameObject.SetActive(true);
        //    Debug.Log("true");
        //    count++;
        //}
        //else if (count % 2 == 0)
        //{
        //    gameObject.SetActive(false);
        //    Debug.Log("false");
        //    count++;
        //}

        GameObject.SetActive(!GameObject.activeSelf);
    }
}
