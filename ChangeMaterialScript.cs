using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterialScript : MonoBehaviour
{
    public GameObject cube, sphere, plane; // Reference to GameObjects
    public Material[] materials; // Array of materials to cycle through
    public Button changeMaterialButton;

    private Renderer cubeRenderer, sphereRenderer, planeRenderer;
    private int currentMaterialIndex = 0;

    void Start()
    {
        // Get the Renderer components of each GameObject
        cubeRenderer = cube.GetComponent<Renderer>();
        sphereRenderer = sphere.GetComponent<Renderer>();
        planeRenderer = plane.GetComponent<Renderer>();

        // Add listener to the button
        changeMaterialButton.onClick.AddListener(ChangeMaterial);
    }

    public void ChangeMaterial()
    {
        // Cycle to the next material
        currentMaterialIndex = (currentMaterialIndex + 1) % materials.Length;

        // Apply the new material to all objects
        cubeRenderer.material = materials[currentMaterialIndex];
        sphereRenderer.material = materials[currentMaterialIndex];
        planeRenderer.material = materials[currentMaterialIndex];
    }
}