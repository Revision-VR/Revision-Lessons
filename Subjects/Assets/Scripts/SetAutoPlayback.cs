using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAutoPlayback : MonoBehaviour
{
    public Material targetMaterial; // Assign the material with the shader to this in the Inspector
    public string autoPlaybackPropertyName = "Auto Playback"; // Name of the shader property controlling auto playback

    void Update()
    {
        // Check if a specific button is pressed (you can change Input.GetKeyDown(KeyCode.X) to your desired button)
        if (Input.GetKeyDown(KeyCode.X))
        {
            // Ensure the material has the property we want to modify
            if (targetMaterial != null && targetMaterial.HasProperty(autoPlaybackPropertyName))
            {
                // Set auto playback to true (1)
                targetMaterial.SetFloat(autoPlaybackPropertyName, 1f);
            }
            else
            {
                Debug.LogWarning("Material or shader property not found.");
            }
        }
    }
}
