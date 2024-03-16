using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class OpenCard : MonoBehaviour
{

    private VideoPlayer _player;
    private Button _enterButton;
    private Button _lessonButton;
    private Button _presentationButton;

    private VideoPlayer _scrollViewPlayer;

    private TMP_Text _infoText;

    private string langugae;

    private void OnEnable()
    {
        _player = gameObject.transform.GetChild(0).gameObject.GetComponent<VideoPlayer>();

        _infoText = gameObject.transform.GetChild(3).gameObject.GetComponent<TMP_Text>();

        _lessonButton = gameObject.transform.GetChild(1).gameObject.GetComponent<Button>();
        _presentationButton = gameObject.transform.GetChild(5).gameObject.GetComponent<Button>();
        _enterButton = gameObject.transform.GetChild(4).gameObject.GetComponent<Button>();
    }

    
    public void WhenEnabled(GameObject obj)
    {
        _infoText.text = obj.transform.GetChild(4).GetComponent<TMP_Text>().text;

        _scrollViewPlayer = obj.transform.GetChild(3).GetComponent<VideoPlayer>();
        _player.clip = _scrollViewPlayer.clip;
        _player.Play();

        _enterButton.onClick.AddListener(() => PressEnterButton(obj));
        _lessonButton.onClick.AddListener(() => PressLessonButton(obj));
        _presentationButton.onClick.AddListener(() => PressPresentationButton());
    }


    private void PressLessonButton(GameObject obj)
    {
        _infoText.text = obj.transform.GetChild(4).GetComponent<TMP_Text>().text;
    }


    private void PressPresentationButton()
    {
        langugae = PlayerPrefs.GetString("Language");

        switch (langugae)
        {
            case "uz":
                _infoText.text = "OТz taqdimotingizni yarating";
                break;

            case "en":
                _infoText.text = "Create your own presentation";
                break;

            case "ru":
                _infoText.text = "—оздайте свою собственную презентацию";
                break;
        }
    }


    private void PressEnterButton(GameObject obj)
    {
        SceneManager.LoadScene(obj.name);
    }

}
