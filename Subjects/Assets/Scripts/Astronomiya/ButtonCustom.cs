using UnityEngine;
using UnityEngine.Events;

public class ButtonCustom : MonoBehaviour
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
