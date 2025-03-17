using UnityEngine;

public class PositionController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed for movement

    void Update()
    {
        // Move the object using arrow keys or WASD
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(new Vector3(moveX, 0, moveZ), Space.World);
    }
}