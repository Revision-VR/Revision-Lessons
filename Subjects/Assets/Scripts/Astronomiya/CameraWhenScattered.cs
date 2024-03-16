using DG.Tweening;
using UnityEngine;

public class CameraWhenScattered : MonoBehaviour
{
    [SerializeField]
    private GameObject _camera;



    public void WhenScattered()
    {
        _camera.transform.DOLocalMove(new Vector3(-0.8737131f, 0.3079379f, 1.232021f), 1.0f);
        _camera.transform.DORotate(new Vector3(16.25f, 51.25f, 0f), 1.0f);
    }

    public void WheAssembled()
    {
        _camera.transform.DOLocalMove(new Vector3(0, 0, 0), 1.0f);
        _camera.transform.DORotate(new Vector3(0, 0, 0), 1.0f);
    }



}
