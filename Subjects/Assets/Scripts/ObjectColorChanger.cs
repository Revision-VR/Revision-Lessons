using UnityEngine;

public class ObjectColorChanger : MonoBehaviour
{
    public Renderer objectRenderer;
    private Material originalMaterial;
    public Material greenColor; // The material to change to when the button is clicked

    void Start()
    {
        //objectRenderer = GetComponent<Renderer>();
        // Store the original material of the object
        originalMaterial = objectRenderer.material;
    }

    public void ChangeBorderColor()
    {
        // If the current material is not the greenColor material, change it to green
        if (objectRenderer.material != greenColor)
        {
            objectRenderer.material = greenColor;
        }
        else
        {
            // If the current material is already green, revert to the original material
            objectRenderer.material = originalMaterial;
        }
    }
}
