using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class VideoController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{


    private VideoPlayer _player;


    void Start()
    {
        _player = GetComponent<VideoPlayer>();
        _player.Pause();
    }



    public void OnPointerEnter(PointerEventData eventData)
    {
        _player.Play();
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        _player.Pause();
    }


}
