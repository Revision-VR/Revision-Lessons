using UnityEngine;

public class ResetOrgans : MonoBehaviour
{
    [SerializeField]
    private Vector3 resetPos;

    [SerializeField]
    private GameObject _pos;

    [SerializeField]
    private GameObject _pos2;


    private bool inSide = false;
    private bool isDragging = false;


    private bool firstTriggerEnter = true;
    private bool firstTriggerStay = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("test"))
        {
            if (!firstTriggerEnter)
            {
                _pos.SetActive(true);
                _pos2.SetActive(false);
            }
            else
            {
                firstTriggerEnter = false;
            }
            inSide = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("test"))
        {
            _pos.SetActive(false);
            inSide = false;
            _pos2.SetActive(isDragging);
        }
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
