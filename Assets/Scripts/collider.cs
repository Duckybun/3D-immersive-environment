using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    public Material broken_screenMaterial;
    public Material greenMaterial;

    private Renderer wallRenderer;
    private bool hasCollided = false;

    void Start()
    {
        // Get the Renderer component of the wall object
        wallRenderer = GetComponent<Renderer>();
        // Set the initial color to red
        wallRenderer.material = greenMaterial;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball") && !hasCollided)
        {
            // Change the wall color to green when the ball collides with it
            wallRenderer.material = broken_screenMaterial;
            hasCollided = true;

            Destroy(collision.gameObject); // Destroy the ball upon collision
        }  
    }
}

