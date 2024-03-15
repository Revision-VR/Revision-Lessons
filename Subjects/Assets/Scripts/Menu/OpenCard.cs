using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class OpenCard : MonoBehaviour
{

    private VideoPlayer _player;
    private Button _button;

    private VideoPlayer _scrollViewPlayer;

    void Start()
    {

        _player = gameObject.transform.GetChild(0).gameObject.GetComponent<VideoPlayer>();
        print(_player);

        _button = gameObject.transform.GetChild(1).gameObject.GetComponent<Button>();

    }

    
    public void WhenEnabled(GameObject obj)
    {
        print(obj.transform.GetChild(3).name);

        _scrollViewPlayer = obj.transform.GetChild(3).GetComponent<VideoPlayer>();

        _player.clip = _scrollViewPlayer.clip;
        _player.Play();

        _button.onClick.AddListener(() => PressButton(obj));
    }


    private void PressButton(GameObject obj)
    {
        SceneManager.LoadScene(obj.name);   
    }





}
