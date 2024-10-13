using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screen_move : MonoBehaviour
{
    public float moveSpeed = 5.0f;  // Speed of camera movement

    void Update()
    {
        // Get input from the keys "A" and "W"
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calculate the new position based on input and speed
        Vector3 moveDirection = new Vector3(horizontal, 0.0f, vertical);
        Vector3 newPosition = transform.position + moveDirection * moveSpeed * Time.deltaTime;

        // Update the camera position
        transform.position = newPosition;
    }
}
