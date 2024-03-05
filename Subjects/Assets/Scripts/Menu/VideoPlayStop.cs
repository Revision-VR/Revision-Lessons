using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class VideoPlayStop : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private VideoPlayer _player;

    public void OnPointerEnter(PointerEventData eventData)
    {
        _player.Play();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        VideoStop();
    }

    private void Start()
    {
        _player = gameObject.GetComponent<VideoPlayer>();

        VideoStop();
    }


    void VideoStop()
    {
        _player.Pause();
    }
}
