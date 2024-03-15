using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField]
    private AudioSource AudioSource;


    [SerializeField] private AudioClip _clipUz;
    [SerializeField] private AudioClip _clipRu;
    [SerializeField] private AudioClip _clipEn;

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

    public void AudioStart()
    {
        //switch (_language)
        //{
        //    case "uz":
        //        _clipUz.
        //        break;

        //    case "ru":
        //        AudioSourceRu.enabled = true;
        //        break;

        //    case "en":
        //        AudioSourceEn.enabled = true;
        //        break;
        //}
    }

}
