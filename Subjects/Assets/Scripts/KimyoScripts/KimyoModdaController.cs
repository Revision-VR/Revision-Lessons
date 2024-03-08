using UnityEngine;

public class KimyoModdaController : MonoBehaviour
{
    [SerializeField]
    private GameObject GameObject;
    [SerializeField]
    private GameObject GameObject2;
    [SerializeField]
    private GameObject GameObject3;


    public void OnClick()
    {
        GameObject2.SetActive(true);
        GameObject3.SetActive(false);
        GameObject.SetActive(false);
    }

    public void OnClick2()
    {
        GameObject2.SetActive(false);
        GameObject3.SetActive(false);
        GameObject.SetActive(true);
    }

    public void OnClick3()
    {
        GameObject2.SetActive(false);
        GameObject3.SetActive(true);
        GameObject.SetActive(false);
    }
}
