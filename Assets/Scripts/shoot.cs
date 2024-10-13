using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject ballPrefab;
    public float shootForce = 10.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ShootBall();
        }
    }

    void ShootBall()
    {
        // Instantiate a new ball object at the shooter's position
        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);
        
        // Get the Rigidbody component of the new ball
        Rigidbody rb = newBall.GetComponent<Rigidbody>();
        
        if (rb != null)
        {
            // Apply a forward force to shoot the ball
            rb.AddForce(transform.forward * shootForce, ForceMode.Impulse);
        }
    }
}
