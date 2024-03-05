using UnityEngine;
using UnityEngine.UI;

public class DrawWithMouse : MonoBehaviour
{
    public Material lineMaterial;  
    public Slider thicknessSlider;


    [SerializeField]
    private Material[] _colors; 


    private LineRenderer currentLine;
    private Vector3 mousePosition;
    private bool drawing = false;
    private Color currentColor;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartDrawing();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopDrawing();
        }

        if (drawing)
        {
            UpdateDrawing();
        }
    }
    

    void StartDrawing()
    {
        GameObject lineObject = new GameObject("Line");
        currentLine = lineObject.AddComponent<LineRenderer>();
        currentLine.material = lineMaterial;
        currentLine.startWidth = currentLine.endWidth = thicknessSlider.value; 
        currentLine.positionCount = 10;
        currentLine.SetPosition(0, GetMouseWorldPosition());
        currentLine.startColor = currentLine.endColor = currentColor; 
        drawing = true;
    }

    void StopDrawing()
    {
        drawing = false;
        currentLine = null;
    }

    void UpdateDrawing()
    {
        currentLine.positionCount++;
        currentLine.SetPosition(currentLine.positionCount - 1, GetMouseWorldPosition());
    }


    Vector3 GetMouseWorldPosition()
    {
        mousePosition = Input.mousePosition;
        mousePosition.z = 8; 
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }


    public void EraseLine()
    {
        LineRenderer[] lines = FindObjectsOfType<LineRenderer>();

        foreach (LineRenderer line in lines)
        {
            Destroy(line.gameObject);
        }

        drawing = false;
        currentLine = null;
    }


    public void UpdateThickness()
    {
        if (currentLine != null)
        {
            currentLine.startWidth = currentLine.endWidth = thicknessSlider.value;
        }
    }

    public void UpdateColor(int colorIndex)
    {
        lineMaterial = _colors[colorIndex];
    }
}
