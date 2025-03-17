using UnityEngine;

public class RotationController : MonoBehaviour
{
    public float rotationSpeed = 100f; // Speed for rotation
    public float mouseSensitivity = 2f; // Sensitivity for mouse rotation

    private Vector3 lastMousePosition;

    void Update()
    {
        // Rotate using 'Q' and 'E' keys
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }

        // Mouse Drag for Rotation
        if (Input.GetMouseButton(1)) // Right Mouse Button
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;
            transform.Rotate(Vector3.up, delta.x * mouseSensitivity, Space.World);
            transform.Rotate(Vector3.right, -delta.y * mouseSensitivity, Space.World);
        }
        lastMousePosition = Input.mousePosition;
    }
}