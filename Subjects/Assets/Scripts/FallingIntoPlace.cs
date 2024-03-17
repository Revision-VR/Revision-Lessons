using UnityEngine;

public class FallingIntoPlace : MonoBehaviour
{
    public bool _mouseDown = false;

    [HideInInspector]
    public bool firstIgnor = false;


    [SerializeField]
    private Vector3 resetPos;

    [SerializeField]
    private GameObject _pos;

    [SerializeField]
    private Material _greenMaterial;

    [SerializeField]
    private Material _pinkMaterial;

    
    private MeshRenderer _renderer;

    [HideInInspector]
    public bool inSide = false;


    private void Start()
    {
        _renderer = _pos.GetComponent<MeshRenderer>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (firstIgnor)
        {
            inSide = true;
            _renderer.enabled = true;
            _renderer.material = _greenMaterial;
        }
        firstIgnor = true;
    }


    private void OnTriggerExit(Collider other)
    {
        _renderer.material = _pinkMaterial;
        inSide = false;
    }



    private void OnMouseDown()
    {
        if (_mouseDown)
        {
            _renderer.material = _pinkMaterial;
            _renderer.enabled = true;
        }
    }


    private void OnMouseUp()
    {
        _renderer.enabled = false;
    }


    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) && inSide)
        {
            ResetPosition();
        }
    }

    public void ResetPosition()
    {
        transform.localPosition = resetPos;
        _renderer.enabled = false;
    }



}
