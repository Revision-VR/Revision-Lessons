using UnityEngine;

public class ResertCamera : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camer2;

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    private Vector3 initialPosition2;
    private Quaternion initialRotation2;

    void Start()
    {
        // Store the initial position and rotation of the object
        initialPosition = Camera1.transform.position;
        initialRotation = Camera1.transform.rotation;

        initialPosition2 = Camer2.transform.position;
        initialRotation2 = Camer2.transform.rotation;
    }

    public void ResetObjectTransform()
    {
        // Reset the position and rotation of the object to their initial values
        Camera1.transform.position = initialPosition;
        Camera1.transform.rotation = initialRotation;

        Camer2.transform.position = initialPosition2;
        Camer2.transform.rotation = initialRotation2;
    }
}
