using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private string _info;
    [SerializeField] private string _infoRu;
    [SerializeField] private string _infoEn;

    public string newLayerName = "Outlined";

    private static GameObject selectedObject;
    private string _language;

    private void Start()
    {
        _language = PlayerPrefs.GetString("Language");
        //if (string.IsNullOrEmpty(_language))
        //{
        //    PlayerPrefs.SetString("Language", "en");
        //}
            PlayerPrefs.SetString("Language", "en");

    }

    public void ForButton()
    {
        if (selectedObject != null && selectedObject != gameObject)
        {
            ResetLayer(selectedObject);
        }

        selectedObject = gameObject;

        //switch (_language)
        //{
        //    case "uz":
        //        TextManager.Instance.ChangableInfo.text = _info;
        //        break;
        //    case "ru":
        //        TextManager.Instance.ChangableInfo.text = _infoRu;
        //        break;

        //    case "en":
        //        TextManager.Instance.ChangableInfo.text = _infoEn;
        //        break;
        //}

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
