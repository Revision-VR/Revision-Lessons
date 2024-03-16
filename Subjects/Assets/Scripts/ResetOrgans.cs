using UnityEngine;

public class ResetOrgans : MonoBehaviour
{
    [SerializeField]
    private Vector3 resetPos;

    [SerializeField]
    private GameObject _pos;

    //[SerializeField]
    //private GameObject _pos2;

    [SerializeField]
    private Material _material1;
    [SerializeField]
    private Material _material2;

    private MeshRenderer _renderer;


    private bool inSide = false;
    private bool isDragging = false;

    private bool firstIgnor = false;

    private void Start()
    {
        _renderer = _pos.GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (firstIgnor)
        {
            //_pos.SetActive(true);
            _renderer.enabled = true;
            _renderer.material = _material1;
            //_pos2.SetActive(false);
            inSide = true;
        }
        firstIgnor = true;

    }

    private void OnTriggerExit(Collider other)
    {
        _renderer.material = _material2;
        //_pos.SetActive(false);
        inSide = false;
        //_pos2.SetActive(isDragging);
    }

    private void OnMouseDown()
    {
        isDragging = true;
        //_pos2.SetActive(true);
        _renderer.material = _material2;
        _renderer.enabled = true;


    }

    private void OnMouseUp()
    {
        isDragging = false;
        //_pos2.SetActive(false);
        _renderer.enabled=false;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) && inSide)
        {
            transform.localPosition = resetPos;
            //_pos.SetActive(false);
            _renderer.enabled = false;
        }
    }
}
