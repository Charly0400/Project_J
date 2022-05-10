using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 1f;
    public float frequency = 1f;
    public float lenght = 1f;

    public enum PlatformType {  horizontal, Vertical, Circular}
    public PlatformType type;

    // Update is called once per frame
    void Update()
    {
        if (type == PlatformType.horizontal)
            transform.position = new Vector3(Mathf.Sin(Time.fixedTime * frequency) * lenght, transform.position.y, transform.position.z);


        //float step = speed * Time.deltaTime;
        //transform.position = new Vector3(transform.position.x + step, transform.position.y + step, transform.position.z);
        //transform.eulerAngles = new Vector3(transform.eulerAngles.x + step, transform.eulerAngles.y + step, transform.eulerAngls.z); 
        //transform.localScale = new Vector3(transform.localScale.x + step, transform.localScale.y, transform.localScale.z);


        else if (type == PlatformType.Vertical)
            transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.fixedTime * frequency) * lenght, transform.position.z);


        else if (type == PlatformType.Circular)
            transform.position = new Vector3(Mathf.Sin(Time.fixedTime * frequency) * lenght, Mathf.Cos(Time.fixedTime * frequency) * lenght, transform.position.z);

    }
}
