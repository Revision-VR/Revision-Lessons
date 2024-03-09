using System.Collections;
using UnityEngine;

public class HeartAnimController01 : MonoBehaviour
{
    public Animator HeartAnim;

    private int Count = 2;
    public GameObject Hearts1;
    public GameObject Hearts2;
    public GameObject Hearts3;
    public GameObject Hearts4;
    private void Start()
    {
        HeartAnim.SetInteger("Heart", 3);

    }

    private void HeartAnimEnter()
    {
        HeartAnim.SetInteger("Heart", 1);
        Count++;
        Hearts1.SetActive(false);
        Hearts2.SetActive(false);
        Hearts3.SetActive(false);

    }
    private void HeartAnimExit()
    {
        //HeartAnim
        Count++;
        StartCoroutine(Kutish());
    }

    IEnumerator Kutish()
    {
        yield return new  WaitForSeconds(1.55f);
        Hearts4.SetActive(false);

        Hearts1.SetActive(true);
        Hearts2.SetActive(true);
        Hearts3.SetActive(true);
    }
    public void OnClickEnter()
    {
        if (Count % 2 == 0)
        {
            HeartAnimEnter();
        }
        else if (Count % 2 != 0)
        {
            HeartAnimExit();
        }
    }

}
