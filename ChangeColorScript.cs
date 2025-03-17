using UnityEngine;
using UnityEngine.UI;

public class ChangeColorScript : MonoBehaviour
{
    public GameObject cube, sphere, plane; // Reference to GameObjects
    public Color[] colors; // Array of colors to cycle through
    public Button changeColorButton;

    private Renderer cubeRenderer, sphereRenderer, planeRenderer;
    private int currentColorIndex = 0;

    void Start()
    {
        // Get the Renderer components of each GameObject
        cubeRenderer = cube.GetComponent<Renderer>();
        sphereRenderer = sphere.GetComponent<Renderer>();
        planeRenderer = plane.GetComponent<Renderer>();

        // Add listener to the button
        changeColorButton.onClick.AddListener(ChangeColor);
    }

    public void ChangeColor()
    {
        // Cycle to the next color
        currentColorIndex = (currentColorIndex + 1) % colors.Length;

        // Apply the new color to all objects
        cubeRenderer.material.color = colors[currentColorIndex];
        sphereRenderer.material.color = colors[currentColorIndex];
        planeRenderer.material.color = colors[currentColorIndex];
    }
}