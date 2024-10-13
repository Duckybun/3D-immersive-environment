using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oculus_control : MonoBehaviour
{
    public GameObject BallPrefab;
    public Transform BallsHolder;
    public float speed;

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            Vector3 headsetForward = Camera.main.transform.forward; // Get the forward direction of the main camera
            GameObject ball = Instantiate(BallPrefab, transform.position, Quaternion.identity, BallsHolder);
            Rigidbody rb = ball.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.velocity = headsetForward * speed;
            }
        }
    }

    public void DeleteAllBalls()
    {
        foreach (Transform ball in BallsHolder)
        {
            Destroy(ball.gameObject);
        }
    }
}