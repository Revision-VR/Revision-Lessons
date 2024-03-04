using UnityEngine;

public class MouseMoveObject : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    private GameObject hitObject;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                isDragging = true;
                offset = hit.transform.position - GetMouseWorldPosition();
                hitObject = hit.collider.gameObject;
            }
        }   

        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }


        if (isDragging)
        {
            Vector3 newPosition = GetMouseWorldPosition() + offset;
            hitObject.transform.position = newPosition;
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }
}
