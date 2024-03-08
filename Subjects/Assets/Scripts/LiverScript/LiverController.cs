using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiverController : MonoBehaviour
{
    private int Count = 2;

    [SerializeField]
    private Animator LiverAnimator;
    private void LiverAnimExit()
    {
        LiverAnimator.SetInteger("Check", 1);
        Count++;
    }

    private void LiverAnimEnter()
    {
        LiverAnimator.SetInteger("Check", 2);
        Count++;
    }

    public void onClick()
    {
        if (Count % 2 == 0)
        {
            LiverAnimEnter();
        }
        else if (Count % 2 != 0)
        {
            LiverAnimExit();
        }
    }
}
