using UnityEngine;
using UnityEngine.UI;

public class BackgroundChanger : MonoBehaviour
{
    public RawImage backgroundImage;
    public Texture[] backgrounds;

    public void ChangeBackground(int backgroundIndex)
    {
        if (backgroundIndex >= 0 && backgroundIndex < backgrounds.Length)
        {
            backgroundImage.texture = backgrounds[backgroundIndex];
        }
        else
        {
            Debug.LogError("Invalid background index!");
        }
    }
}
