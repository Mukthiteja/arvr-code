using UnityEngine;

public class GeoTransform : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed for movement
    public float rotationSpeed = 100f; // Speed for rotation
    public float scaleSpeed = 0.5f; // Speed for scaling
    public float mouseSensitivity = 2f; // Sensitivity for mouse rotation

    private Vector3 lastMousePosition;

    void Update()
    {
        // Move the object using arrow keys or WASD
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(new Vector3(moveX, 0, moveZ), Space.World);

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

        // Scale using '+' and '-' keys
        if (Input.GetKey(KeyCode.Equals)) // '+' key
        {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Minus)) // '-' key
        {
            transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
        }

        // Mouse Scroll for Scaling
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0)
        {
            transform.localScale += Vector3.one * scroll * scaleSpeed;
        }
    }
}
