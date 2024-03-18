using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private string _info;
    [SerializeField] private string _infoRu;
    [SerializeField] private string _infoEn;


    [SerializeField] private AudioClip _clipUz;
    [SerializeField] private AudioClip _clipRu;
    [SerializeField] private AudioClip _clipEn;

    public string newLayerName = "Outlined";

    private static GameObject selectedObject;
    private string _language;

    private void Start()
    {
        _language = PlayerPrefs.GetString("Language");

        if (string.IsNullOrEmpty(_language))
        {
            _language = "en";
            PlayerPrefs.SetString("Language", _language);
        }

    }

    public void ForButton()
    {
        _language = PlayerPrefs.GetString("Language");

        if (selectedObject != null && selectedObject != gameObject)
        {
            ResetLayer(selectedObject);
        }

        selectedObject = gameObject;

        switch (_language)
        {
            case "uz":
                TextManager.Instance.ChangableInfo.text = _info;
                TextManager.Instance.PlayAudio(_clipUz);
                break;

            case "ru":
                TextManager.Instance.ChangableInfo.text = _infoRu;
                TextManager.Instance.PlayAudio(_clipRu);
                break;

            case "en":
                TextManager.Instance.ChangableInfo.text = _infoEn;
                TextManager.Instance.PlayAudio(_clipEn);
                break;
        }

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
