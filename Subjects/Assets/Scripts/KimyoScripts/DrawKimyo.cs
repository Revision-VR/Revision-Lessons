using UnityEngine;

public class DrawKimyo : MonoBehaviour
{
    public DrawWithMouse drawWithMouse;

    public GameObject draw;

    public bool firstClick = true;

    private CameraControl _cameraControlScript;

    private void Start()
    {
        _cameraControlScript = Camera.main.gameObject.GetComponent<CameraControl>();
    }

    public void OnClick()
    {
        drawWithMouse.EraseLine();

        if (firstClick)
        {
            draw.SetActive(true);
        }
        else
        {
            draw.SetActive(false);
        }

        _cameraControlScript.enabled = !draw.activeSelf;

        // Toggle mouseMove script based on drawing state (if needed)
        // mouseMove.enabled = !draw.activeSelf;

        firstClick = !firstClick;
    }
}
