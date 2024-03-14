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

    void Start()
    {

        _player = gameObject.transform.GetChild(0).gameObject.GetComponent<VideoPlayer>();
        _button = gameObject.transform.GetChild(1).gameObject.GetComponent<Button>();

    }

    
    public void WhenEnabled(GameObject obj)
    {
        print(obj.transform.GetChild(3).name);

        _player.clip = obj.transform.GetChild(3).GetComponent<VideoPlayer>().clip;
        _player.Play();

        _button.onClick.AddListener(() => PressButton(obj));
    }


    private void PressButton(GameObject obj)
    {
        SceneManager.LoadScene(obj.name);   
    }





}
