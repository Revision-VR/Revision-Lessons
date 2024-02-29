using UnityEngine;
using UnityEngine.UI;

public class DrawWithMouse : MonoBehaviour
{
    public Material lineMaterial;   // Material for the line

    [SerializeField]
    private Material[] _colors;

    public KeyCode eraseKey = KeyCode.Mouse1;  // Key to use for erasing

    private LineRenderer currentLine;
    private Vector3 mousePosition;
    private bool drawing = false;

    // UI elements for color and thickness selection
    public Slider thicknessSlider;
    public Button[] colorButtons; // Array of color selection buttons

    private Color currentColor; // Current selected color

    void Start()
    {
        // Set default color to the color of the first color button
        currentColor = colorButtons[0].image.color;
    }

    void Update()
    {
        // Check if erase key is pressed
        if (Input.GetKeyDown(eraseKey))
        {
            // Erase line if right mouse button is held down
            EraseLine();
        }

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
        currentLine.startWidth = currentLine.endWidth = thicknessSlider.value; // Set thickness
        currentLine.positionCount = 1;
        currentLine.SetPosition(0, GetMouseWorldPosition());
        currentLine.startColor = currentLine.endColor = currentColor; // Set color
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

    public void EraseLine()
    {
        // Find all objects with LineRenderer component (assuming lines are drawn using LineRenderer)
        LineRenderer[] lines = FindObjectsOfType<LineRenderer>();

        // Destroy each line object
        foreach (LineRenderer line in lines)
        {
            Destroy(line.gameObject);
        }

        // Reset drawing state to allow drawing again
        drawing = false;
        currentLine = null;
    }

    Vector3 GetMouseWorldPosition()
    {
        mousePosition = Input.mousePosition;
        mousePosition.z = 10; // Distance from the camera
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }

    // Method to update line thickness when slider value changes
    public void UpdateThickness()
    {
        if (currentLine != null)
        {
            currentLine.startWidth = currentLine.endWidth = thicknessSlider.value;
        }
    }

    // Method to update line color when color button is clicked
    public void UpdateColor(int colorIndex)
    {
        lineMaterial = _colors[colorIndex];
    }
}
