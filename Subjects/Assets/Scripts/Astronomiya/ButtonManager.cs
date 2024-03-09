using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private string _info;
    public string newLayerName = "Outlined";

    private static GameObject selectedObject;

    public void ForButton()
    {
        if (selectedObject != null && selectedObject != gameObject)
        {
            ResetLayer(selectedObject);
        }

        selectedObject = gameObject;

        TextManager.Instance.ChangableInfo.text = _info;
        int newLayer = LayerMask.NameToLayer(newLayerName);
        gameObject.layer = newLayer;
    }

    private void OnMouseDown()
    {
       

        ForButton();
    }


    private void ResetLayer(GameObject obj)
    {
        int defaultLayer = LayerMask.NameToLayer("Default");
        obj.layer = defaultLayer;
    }
}
