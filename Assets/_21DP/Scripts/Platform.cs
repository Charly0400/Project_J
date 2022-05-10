using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 1f;
    public float frenquency = 1f;
    public float lenght = 1f;

    public enum PlatformType { Horizontal, Vertical, Circular }
    public PlatformType type;

    private Rigidbody rb;

    Vector3 target;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (type == PlatformType.Horizontal)
            target = new Vector3(Mathf.Sin(Time.fixedTime * frenquency) * lenght, transform.position.y,
                transform.position.z);

        rb.MovePosition(target);
        /*if (type == PlatformType.Horizontal)
            transform.position = new Vector3(Mathf.Sin(Time.fixedTime * frenquency) * lenght, transform.position.y, transform.position.z);

        else if (type == PlatformType.Vertical)
            transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.fixedTime * frenquency) * lenght, transform.position.z);

        else if (type == PlatformType.Circular)
            transform.position = new Vector3(Mathf.Cos(Time.fixedTime * frenquency) * lenght,
                                             Mathf.Sin(Time.fixedTime * frenquency) * lenght,
                                             transform.position.z);  */
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PLayer")
        {
            Plarform_Attacher attacher = other.gameObject.GetComponent<Plarform_Attacher>();
            attacher.onPlatform = true;
            attacher.platformRigidBody = rb;
            attacher.rb.isKinematic = false;
            attacher.rb.useGravity = false;
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PLayer")
        {
            other.gameObject.GetComponent<Plarform_Attacher>().onPlatform = false;
            
        }
    }
}

