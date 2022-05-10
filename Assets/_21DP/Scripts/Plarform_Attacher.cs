using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plarform_Attacher : MonoBehaviour
{

    public bool onPlatform = false;
    public Rigidbody rb;
    public Rigidbody platformRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (onPlatform)
            rb.velocity += new Vector3(platformRigidBody.velocity.x, 0, platformRigidBody.velocity.z);

    }
} 
