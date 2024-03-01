using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCamera : MonoBehaviour
{
    public float repeatSpeed = 1f; // Speed of repeated movement
    private Vector3 lastMousePosition; // Last recorded mouse position


    private void Awake()
    {
        
    }

    void Update()
    {
        // Check if middle mouse button is pressed
        if (Input.GetMouseButtonDown(2))
        {
            lastMousePosition = Input.mousePosition; // Record the initial mouse position
        }
        // Check if middle mouse button is held down
        else if (Input.GetMouseButton(2))
        {
            // Calculate the movement based on the difference in mouse position
            Vector3 movement = (Input.mousePosition - lastMousePosition) * repeatSpeed * Time.deltaTime;

            // Apply the movement to the camera or any other GameObject
            transform.Translate(-movement);

            // Update the last recorded mouse position
            lastMousePosition = Input.mousePosition;
        }
    }
}
