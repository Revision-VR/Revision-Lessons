using UnityEngine;

public class ObjectColorChanger : MonoBehaviour
{
    public Renderer objectRenderer;
    private Material originalMaterial;
    public Material greenColor;

    void Start()
    {
        originalMaterial = objectRenderer.material;
    }

    public void ChangeBorderColor()
    {
        if (objectRenderer.material != greenColor)
        {
            objectRenderer.material = greenColor;
        }
        else
        {
            objectRenderer.material = originalMaterial;
        }
    }
}
