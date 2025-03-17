using UnityEngine;
using UnityEngine.UI;

public class ChangeTextureScript : MonoBehaviour
{
    public GameObject cube, sphere, plane; // Reference to GameObjects
    public Texture[] textures; // Array of textures to cycle through
    public Button changeTextureButton;

    private Renderer cubeRenderer, sphereRenderer, planeRenderer;
    private int currentTextureIndex = 0;

    void Start()
    {
        // Get the Renderer components of each GameObject
        cubeRenderer = cube.GetComponent<Renderer>();
        sphereRenderer = sphere.GetComponent<Renderer>();
        planeRenderer = plane.GetComponent<Renderer>();

        // Add listener to the button
        changeTextureButton.onClick.AddListener(ChangeTexture);
    }

    public void ChangeTexture()
    {
        // Cycle to the next texture
        currentTextureIndex = (currentTextureIndex + 1) % textures.Length;

        // Apply the new texture to all objects
        cubeRenderer.material.mainTexture = textures[currentTextureIndex];
        sphereRenderer.material.mainTexture = textures[currentTextureIndex];
        planeRenderer.material.mainTexture = textures[currentTextureIndex];
    }
}