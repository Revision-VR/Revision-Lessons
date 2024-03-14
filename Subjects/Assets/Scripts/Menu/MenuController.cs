using TMPro;
using UnityEngine;
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
    private string[] _upNamesRu; 

    [SerializeField]
    private string[] _upNamesEn;

    [SerializeField]
    private VideoClip[] _rigtVideoClips;

    [SerializeField]
    private TMP_Text _upNamesText;

    [SerializeField]
    private VideoPlayer _rightVideoPlayer;



    private bool _mainDropDown = false;
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



    public void PressMainButtons(int index)
    {
        DisableLeftBarTexts();


        _rightVideoPlayer.gameObject.SetActive(false);

        if (index == 0)
        {
            MainDropDown();
            DisableLessons();
            _scrollViewsLessons[5].SetActive(true);
            switch (_language)
            {
                case "uz":
                    _upNamesText.text = "Darslar";
                    break;

                case "ru":
                    _upNamesText.text = "Уроки";
                    break;

                case "en":
                    _upNamesText.text = "Lessons";
                    break;
            }
        }


        else if (_mainDropDown)
        {
            MainDropDown();
        }


        if (index == 1)
        {
            ShowFavorites();
            switch (_language)
            {
                case "uz":
                    _upNamesText.text = "Tanlanganlar";
                    break;

                case "ru":
                    _upNamesText.text = "Избранное";
                    break;

                case "en":
                    _upNamesText.text = "Favorites";
                    break;
            }
        }


        else if (index == 2)
        {
            ShowSettings();
            switch (_language)
            {
                case "uz":
                    _upNamesText.text = "Sozlamalar";
                    break;

                case "ru":
                    _upNamesText.text = "Настройки";
                    break;

                case "en":
                    _upNamesText.text = "Settings";
                    break;
            }
        }


        else if (index == 2)
        {
            // Taqdimotlar
            switch (_language)
            {
                case "uz":
                    _upNamesText.text = "Taqdimotlar";
                    break;

                case "ru":
                    _upNamesText.text = "Презентации";
                    break;

                case "en":
                    _upNamesText.text = "Presentations";
                    break;
            }
        }
    }



    public void SelectLessons(int _index)
    {
        _rightVideoPlayer.gameObject.SetActive(true);


        if (!_mainDropDown)
        {
            MainDropDown();
        }

        DisableLessons();
        DisableLessonsTexts();

        switch (_language)
        {
            case "uz":
                _upNamesText.text = _upNames[_index];
                break;

            case "ru":
                _upNamesText.text = _upNamesRu[_index];
                break;

            case "en":
                _upNamesText.text = _upNamesEn[_index];
                break;
        }

        _rightVideoPlayer.clip = _rigtVideoClips[_index];
        _scrollViewsLessons[_index].SetActive(true);

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
