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


        cameraTransform1.DOLocalMove(new Vector3(-1f, 0.03f, -2.22f), 1.0f);

        cameraTransform.DORotate(new Vector3(0.316f, 39.951f, 0.265f), 1.0f);
    }

    public void ResetCameraPositionAndRotation()
    {
        Transform cameraTransform = mainCameraObject.transform;
        Transform cameraTransform1 = mainCamera.transform;

        cameraTransform1.DOMove(initialCameraPosition, 1.0f);

        cameraTransform.DORotate(initialCameraRotation.eulerAngles, 1.0f);
    }
}
