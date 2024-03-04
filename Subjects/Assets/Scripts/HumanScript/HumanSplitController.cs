using UnityEngine;

public class HumanSplitController : DotweenTest
{
    public Animator humanAnim;

    private int count = 2;

    private void StartAnim()
    {
        humanAnim.SetInteger("Check", 1);
        ChangeCameraPositionAndRotation();
        count++;
    }

    private void ExitAnim()
    {
        humanAnim.SetInteger("Check", 2);
        ResetCameraPositionAndRotation();
        count++;
    }

    public void OnClick()
    {
        if (count % 2 == 0)
        {
            StartAnim();
        }
        else if (count % 2 != 0)
        {
            ExitAnim();
        }
    }
}
