using UnityEngine;

public class SetAutoPlayback : MonoBehaviour
{
    public Material material;
    //public Shader shader;
    private string boolPropertyName = "_B_autoPlayback";

    void Start()
    {
       
    }

     void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            if (material != null && !string.IsNullOrEmpty(boolPropertyName))
            {
                float currentValue = material.GetFloat(boolPropertyName);

                if (currentValue == 1f)
                {
                    material.SetFloat(boolPropertyName, 0f);
                    Debug.Log("Changed boolean property to false.");
                }
                else if (currentValue == 0f)
                {
                    Debug.Log("Boolean property is already false.");
                }
            }
            else
            {
                Debug.LogWarning("Material or boolean property name not provided.");
            }
        }
    }

    public void OnOfAnimation()
    {
        if (material != null && !string.IsNullOrEmpty(boolPropertyName))
        {
            float currentValue = material.GetFloat(boolPropertyName);

            if (currentValue == 1f)
            {
                material.SetFloat(boolPropertyName, 0f);
                Debug.Log("Changed boolean property to false.");
            }
            else if (currentValue == 0f)
            {
                material.SetFloat(boolPropertyName, 1f);
                Debug.Log("Changed boolean property to true.");
            }
        }
        else
        {
            Debug.LogWarning("Material or boolean property name not provided.");
        }
    }



}