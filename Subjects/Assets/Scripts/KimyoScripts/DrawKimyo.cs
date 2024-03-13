using UnityEngine;

public class DrawKimyo : MonoBehaviour
{
    public GameObject modda;
    public GameObject draw;
    public bool firstClick = true;

    private CameraControl _cameraControlScript;
    private MouseMoveObject mouseMove;

    private void Start()
    {
        _cameraControlScript = Camera.main.gameObject.GetComponent<CameraControl>();
        mouseMove = modda.GetComponent<MouseMoveObject>();
    }

    public void OnClick()
    {

        if (firstClick)
        { 
            draw.SetActive(true);
        }
        else
        {
            draw.SetActive(false);
        }

        _cameraControlScript.enabled = !draw.activeSelf;
        mouseMove.enabled = !draw.activeSelf;

        firstClick = !firstClick;
    }

}
