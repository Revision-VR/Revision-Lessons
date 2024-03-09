using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private string _info;

    private void OnMouseDown()
    {
        ForButton();
    }

    public void ForButton()
    {
        TextManager.Instance.ChangableInfo.text = _info;
    }

}
