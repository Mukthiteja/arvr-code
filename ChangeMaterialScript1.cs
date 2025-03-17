using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterialScript : MonoBehaviour
{
    public GameObject cube, sphere, plane; // Reference to GameObjects

    public Material CubeMaterial, SphereMaterial, PlaneMaterial; // New Materials
    public Texture Texture1, Texture2, Texture3; // New Textures
    public Button ChangeAppearanceB;

    private Renderer cubeRenderer, sphereRenderer, planeRenderer;

    void Start()
    {
        // Get the Renderer components of each GameObject
        cubeRenderer = cube.GetComponent<Renderer>();
        sphereRenderer = sphere.GetComponent<Renderer>();
        planeRenderer = plane.GetComponent<Renderer>();
        ChangeAppearanceB.onClick.AddListener(ChangeAppearance);
    }

    public void ChangeAppearance()
    {
        // Change Material
        cubeRenderer.material = CubeMaterial;
        sphereRenderer.material = SphereMaterial;
        planeRenderer.material = PlaneMaterial;

        // Change Texture
        cubeRenderer.material.mainTexture = Texture1;
        sphereRenderer.material.mainTexture = Texture2;
        planeRenderer.material.mainTexture = Texture3;

        // Change Color
        cubeRenderer.material.color = Color.yellow;
        sphereRenderer.material.color = Color.green;
        planeRenderer.material.color = Color.red;

    }
}