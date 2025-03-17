using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f; // Jump strength
    private Rigidbody rb;
    private bool isGrounded; // To check if the player is on the ground

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get Rigidbody component
    }

    void Update()
    {
        float moveY = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(new Vector3(moveZ, 0, -moveY), Space.World);

        // Jump functionality
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // Prevent multiple jumps
        }
    }

    // Detect Ground to allow jumping
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}