using UnityEngine;

public class LungAnimScriptController : MonoBehaviour
{
    private int Count = 2;

    [SerializeField]
    private Animator LungAnimator;

    public bool canMove = true;

    private void LungAnimExit()
    {
        LungAnimator.SetInteger("Lung", 1);
        Count++;
    }

    private void LungAnimEnter()
    {
        LungAnimator.SetInteger("Lung", 2);
        Count++;
    }

    public void onClick()
    {
        LungAnimator.enabled = true;
        
        if (Count % 2 == 0)
        {
            LungAnimEnter();
            canMove = false;
        }
        else if (Count % 2 != 0)
        {
            LungAnimExit();
            canMove = true;
        }
    }


}