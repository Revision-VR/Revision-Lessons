using DG.Tweening;
using UnityEngine;

public class DotweenTest : MonoBehaviour
{
    private Quaternion initialCameraRotation;
    private Vector3 initialCameraPosition;
    public GameObject mainCameraObject;
    public GameObject mainCamera;


    private void Start()
    {
        initialCameraRotation = mainCameraObject.transform.rotation;
        initialCameraPosition = mainCamera.transform.position;
        Debug.Log("Initial Camera Rotation: " + initialCameraRotation);
    }

    public void ChangeCameraPositionAndRotation()
    {
        Transform cameraTransform = mainCameraObject.transform;
        Transform cameraTransform1 = mainCamera.transform;


        cameraTransform1.DOLocalMove(new Vector3(-0.7650259f, 0.9576438f, -2.330027f), 1.0f);

        cameraTransform.DORotate(new Vector3(17.5f, 46.25f, 0f), 1.0f);
    }

    public void ResetCameraPositionAndRotation()
    {
        Transform cameraTransform = mainCameraObject.transform;
        Transform cameraTransform1 = mainCamera.transform;

        cameraTransform1.DOMove(initialCameraPosition, 1.0f);

        cameraTransform.DORotate(initialCameraRotation.eulerAngles, 1.0f);
    }
}
