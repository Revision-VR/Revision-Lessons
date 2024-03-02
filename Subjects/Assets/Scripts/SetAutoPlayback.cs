using UnityEngine;

public class SetAutoPlayback : MonoBehaviour
{
    public Material material;
    //public Shader shader;
    private string boolPropertyName = "Auto Playback";

    void Start()
    {
        if (material != null && !string.IsNullOrEmpty(boolPropertyName))
        {
            float currentValue = material.GetFloat(boolPropertyName);

            if (currentValue == 0f)
            {
                material.SetFloat(boolPropertyName, 1f);
                Debug.Log("Changed boolean property to true.");
            }
            else if (currentValue == 1f) 
            {
                Debug.Log("Boolean property is already true.");
            }
        }
        else
        {
            Debug.LogWarning("Material or boolean property name not provided.");
        }
    }
   
}