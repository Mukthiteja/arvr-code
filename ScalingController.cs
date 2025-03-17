using UnityEngine;

public class ScalingController : MonoBehaviour
{
    public float scaleSpeed = 0.5f; // Speed for scaling

    void Update()
    {
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