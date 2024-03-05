using UnityEngine;

public class AnimController : MonoBehaviour
{
    [SerializeField]
    private SphereCollider boxCollider1;
    [SerializeField]
    private SphereCollider boxCollider2;
    [SerializeField]
    private SphereCollider boxCollider3;
    int a = 1;

    void Start()
    {
        boxCollider1.enabled = false;
        boxCollider2.enabled = false;
        boxCollider3.enabled = false;
    }
    public void BoxColliderContoller()
    {

        if (a % 2 == 0)
        {
            boxCollider1.enabled = false;
            boxCollider2.enabled = false;
            boxCollider3.enabled = false;
            a++;
        }
        else if (a % 2 != 0)
        {
            boxCollider1.enabled = true;
            boxCollider2.enabled = true;
            boxCollider3.enabled = true;
            a++;
        }
    }
}
