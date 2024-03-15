using UnityEngine;

public class ChangeCameraPosition : MonoBehaviour
{
    public GameObject markazCamera;
    public GameObject yonCamera;
    public GameObject tepaCamera;
    public GameObject asosiyCamera;

    public void ChangeForMarkazCamera()
    {
        markazCamera.SetActive(true);
        yonCamera.SetActive(false);
        tepaCamera.SetActive(false);
        asosiyCamera.SetActive(false);
    }
    public void ChangeForYonCamera()
    {
        yonCamera.SetActive(true);
        markazCamera.SetActive(false);
        tepaCamera.SetActive(false);
        asosiyCamera.SetActive(false);
    }
    public void ChangeForTepaCamera()
    {
        tepaCamera.SetActive(true);
        yonCamera.SetActive(false);
        markazCamera.SetActive(false);
        asosiyCamera.SetActive(false);
    }
    public void ChangeForBaseCamera()
    {
        asosiyCamera.SetActive(true);
        tepaCamera.SetActive(false);
        yonCamera.SetActive(false);
        markazCamera.SetActive(false);      
    }
}
