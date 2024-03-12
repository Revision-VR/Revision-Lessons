using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnim : MonoBehaviour
{
    private bool isRotating = false;

    // Update is called once per frame
    void Update()
    {
        // Check for input to toggle rotation
        if (Input.GetKeyDown(KeyCode.X))
        {
            isRotating = !isRotating; // Toggle the rotation flag
        }

        // Rotate the object if the flag is set to true
        if (isRotating)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 20f); // Adjust rotation speed as needed
        }
    }
}
