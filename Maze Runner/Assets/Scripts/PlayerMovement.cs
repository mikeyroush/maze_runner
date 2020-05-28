//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 50f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    // Fixed Update is smoother when messing with physics
    void FixedUpdate()
    {
        //use deltaTime to fix the magnitude of the force
        rb.AddForce(0,0,forwardForce*Time.deltaTime);

        //input can be improved
        if(Input.GetKey("a")){
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
    }
}
