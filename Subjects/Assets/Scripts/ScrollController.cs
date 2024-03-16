using UnityEngine;

public class ScrollController : MonoBehaviour
{
    [SerializeField]
    private GameObject GameObject;

    [SerializeField]
    private GameObject[] GameObjectsFalse;

    public void SetActiveFalse()
    {
        foreach (GameObject obj in GameObjectsFalse)
        {
            obj.SetActive(false);
        }
    }


    public void OnClick()
    {
        GameObject.SetActive(!GameObject.activeSelf);
    }
}
