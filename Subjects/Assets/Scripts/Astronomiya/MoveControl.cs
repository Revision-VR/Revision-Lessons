using Unity.VisualScripting;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    public Animator animator;
    public GameObject gameObject;
    private int a = 3;

    private MouseMoveObject move;

    private void Start()
    {
        move = animator.gameObject.GetComponent<MouseMoveObject>();
        move.enabled = false;
        
    }

    public void AnimaotorFalseAndTrue()
    {
        animator.enabled = !animator.enabled;
        if (a % 2 != 0)
        {
            gameObject.SetActive(true);
            move.enabled = true;
        }
        else if (a % 2 == 0)
        {
            move.enabled = false;
            gameObject.SetActive(false);
        }
    }
}