using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColorChange : MonoBehaviour
{
    public Material redMaterial;
    public Material greenMaterial;

    private Renderer wallRenderer;
    private bool hasCollided = false;

    void Start()
    {
        // Get the Renderer component of the wall object
        wallRenderer = GetComponent<Renderer>();
        // Set the initial color to red
        wallRenderer.material = redMaterial;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball") && !hasCollided)
        {
            // Change the wall color to green when the ball collides with it
            wallRenderer.material = greenMaterial;
            hasCollided = true;
        }
    }
}

