using UnityEngine;
using UnityEngine.Events;

public class CustomButton : MonoBehaviour
{
    public UnityEvent onClick;

    private bool isHovering = false;

    void Update()
    {

        if (IsMouseOver())
        {
            if (!isHovering)
            {

                isHovering = true;
                OnHoverEnter();
            }


            if (Input.GetMouseButtonDown(0))
            {

                onClick.Invoke();
            }
        }
        else
        {
            if (isHovering)
            {
                isHovering = false;
                OnHoverExit();
            }
        }
    }

    bool IsMouseOver()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        return Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject;
    }

    void OnHoverEnter()
    {

        Debug.Log("Mouse entered!");
    }

    void OnHoverExit()
    {

        Debug.Log("Mouse exited!");
    }
}
