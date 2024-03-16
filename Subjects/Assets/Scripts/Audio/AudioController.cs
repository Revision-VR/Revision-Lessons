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
        //        AudioSource.clip = _clipUz;
        //        AudioSource.Play();
        //        break;

        //    case "ru":
        //        AudioSource.clip = _clipRu;
        //        AudioSource.Play();
        //        break;

        //    case "en":
        //        AudioSource.clip = _clipEn;
        //        AudioSource.Play();
        //        break;
        //}
    }

}