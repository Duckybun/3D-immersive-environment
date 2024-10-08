using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMappingSample : MonoBehaviour
{

    public GameObject debugInput;
    public Material Red;
    public Material Green;

    //Get the Mesh Renderer component of the sphere to change the material
    //Solution 1;
    //private MeshRenderer meshRenderer;

    //private void Awake()
    //{
    //    meshRenderer = debugInput.GetComponent<MeshRenderer>();
    //}
    
    private void Update()
    {

        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {
            //Event Trigger: sphere turn red
            debugInput.GetComponent<MeshRenderer>().material = Red;

        }

        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            //Event Trigger: sphere turn green
            debugInput.GetComponent<MeshRenderer>().material = Green;
        }
    }
}
