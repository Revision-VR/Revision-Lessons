using UnityEngine;
using UnityEngine.SceneManagement;

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
        _cameraControlScript = Camera.main.gameObject.GetComponent<CameraControl>();


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
        firstClick = !firstClick;
    }

    public void PressExitButton()
    {
        SceneManager.LoadScene("Menu");
    }

}
