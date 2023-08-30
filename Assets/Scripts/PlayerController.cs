using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Adjustable speed in the Inspector

    private void Start()
    {
        // Initialization code if needed
    }

    private void FixedUpdate()
    {
        // Get input values
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        
        // Normalize the movement vector to avoid diagonal movement being faster
        movement.Normalize();

        // Move the player
        transform.Translate(movement * speed * Time.fixedDeltaTime);
    }
}
