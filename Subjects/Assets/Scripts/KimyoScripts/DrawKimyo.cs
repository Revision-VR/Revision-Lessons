using UnityEngine;

public class DrawKimyo : MonoBehaviour
{
    public GameObject modda;
    public GameObject draw;
    public bool firstClick = true;

    private CameraControl _cameraControlScript;

    private void Start()
    {
        _cameraControlScript = Camera.main.gameObject.GetComponent<CameraControl>();
    }

    public void OnClick()
    {

        if (firstClick)
        { 
            draw.SetActive(true);
            ToggleMouseMoveObject(false);
        }
        else
        {
            draw.SetActive(false);
            ToggleMouseMoveObject(true);
        }
        _cameraControlScript.enabled = !draw.activeSelf;

        firstClick = !firstClick;
    }


    private void ToggleMouseMoveObject(bool enable)
    {
        if (modda == null)
        {
            Debug.LogError("modda not assigned!");
            return;
        }

        MouseMoveObject mouseMove = modda.GetComponent<MouseMoveObject>();
        if (mouseMove != null)
        {
            mouseMove.enabled = enable;
        }
        else
        {
            Debug.LogError("Mouse Move Object component not found on animButton!");
        }
    }
}
