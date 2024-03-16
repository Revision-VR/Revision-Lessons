using DG.Tweening;
using UnityEngine;

public class DotweenTest : MonoBehaviour
{
    private Quaternion initialCameraRotation;
    private Vector3 initialCameraPosition;

    public GameObject mainCamera;

   /* private void Start()
    {
        initialCameraRotation = mainCamera.transform.rotation;
        initialCameraPosition = mainCamera.transform.position;
    }*/

    public void ChangeCameraPositionAndRotation()
    {
        print(mainCamera);
        //mainCamera.transform.DOLocalMove(new Vector3(-0.8737131f, 0.3079379f, 1.232021f), 1.0f);
        //mainCamera.transform.DORotate(new Vector3(16.25f, 51.25f, 0f), 1.0f);
    }

    /*public void ResetCameraPositionAndRotation()
    {
        mainCamera.transform.DOMove(initialCameraPosition, 1.0f);
        mainCamera.transform.DORotate(initialCameraRotation.eulerAngles, 1.0f);
    }*/
}
