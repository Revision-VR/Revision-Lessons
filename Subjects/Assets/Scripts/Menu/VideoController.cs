using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class VideoController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{


    private VideoPlayer _player;



    void OnEnable()
    {
        _player = GetComponent<VideoPlayer>();

        StartCoroutine(StartWait());
    }

    IEnumerator StartWait()
    {
        _player.Play();

        yield return new WaitForSeconds(0.5f);

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
