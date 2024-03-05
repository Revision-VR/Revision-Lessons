using UnityEngine;

public class LungAnimScriptController : MonoBehaviour
{
    private int Count = 2;

    [SerializeField]
    private Animator LungAnimator;

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
        if (Count % 2 == 0)
        {
            LungAnimEnter();
        }
        else if (Count % 2 != 0)
        {
            LungAnimExit();
        }
    }
}