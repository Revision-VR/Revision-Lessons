using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MoveControl : MonoBehaviour
{
    public Animator animator;
    public GameObject _colliderObject;
    public GameObject _bgImage;

    [SerializeField]
    private FallingIntoPlace _follower;

    private int a = 3;

    private MouseMoveObject move;
    private CameraControl _cameraControl;

    private void Start()
    {
        _cameraControl = Camera.main.gameObject.GetComponent<CameraControl>();
        move = animator.gameObject.GetComponent<MouseMoveObject>();
        move.enabled = false;
    }

    public void AnimaotorFalseAndTrue()
    {
        _bgImage.SetActive(!_bgImage.activeSelf);
        _cameraControl.enabled = !_cameraControl.enabled;
        animator.enabled = !animator.enabled;

        _colliderObject.SetActive(!_colliderObject.activeSelf);

        move.enabled = !move.enabled;
        if (!move.enabled)
        {
            _follower.firstIgnor = false;
        }

    }
}