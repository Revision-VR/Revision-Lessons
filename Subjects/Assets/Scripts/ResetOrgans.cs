using UnityEngine;

public class ResetOrgans : MonoBehaviour
{
    [SerializeField]
    private Vector3 resetPos;

    [SerializeField]
    private GameObject _pos;

    [SerializeField]
    private GameObject _pos2;

    [SerializeField]
    private Material _materialR;

    private bool inSide = false;
    private bool isDragging = false;


    private void OnTriggerEnter(Collider other)
    {
        _pos.SetActive(true);
        _pos2.SetActive(false);
        inSide = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _pos.SetActive(false);
        inSide = false;
        _pos2.SetActive(isDragging);
    }

    private void OnMouseDown()
    {
        isDragging = true;
        _pos2.SetActive(true);
    }

    private void OnMouseUp()
    {
        isDragging = false;
        _pos2.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) && inSide)
        {
            transform.localPosition = resetPos;
            _pos.SetActive(false);
        }
    }
}
