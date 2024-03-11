using UnityEngine;

public class HumanSplitController : DotweenTest
{
    public Animator humanAnim;
    public GameObject draw;
    public GameObject animButton;

    private int count = 2;

    public bool firstClick = true;

    private void StartAnim()
    {
        humanAnim.SetInteger("Check", 1);
        ChangeCameraPositionAndRotation();
        IncrementCount();
    }

    private void ExitAnim()
    {
        humanAnim.SetInteger("Check", 2);
        ResetCameraPositionAndRotation();
        IncrementCount();
    }

    private void IncrementCount()
    {
        count++;
    }

    public void OnClick()
    {
        if (count % 2 == 0)
        {
            StartAnim();
        }
        else
        {
            ExitAnim();
        }

        ToggleCameraControl(true);
    }

    public void OnClickDraw()
    {
        if (firstClick)
        {
            draw.SetActive(true);
            ToggleCameraControl(false);
        }
        else
        {
            draw.SetActive(false);
        }
        firstClick = !firstClick;
    }

    private void ToggleCameraControl(bool enable)
    {
        if (animButton == null)
        {
            Debug.LogError("animButton not assigned!");
            return;
        }

        CameraControl cameraControl = animButton.GetComponent<CameraControl>();
        if (cameraControl != null)
        {
            cameraControl.enabled = enable;
        }
        else
        {
            Debug.LogError("CameraControl component not found on animButton!");
        }
    }
}
