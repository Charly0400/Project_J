using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Transform player;
    public static Transform currentTarget;
    public float speed;

    Vector3 direction = Vector3.zero;
    Vector3 normalizaDir = Vector3.zero;
    private void Start()
    {
        currentTarget = player;
    }

    void Update()
    {
        if (Vector3.Distance(currentTarget.position, transform.position) <1 )
        {
            return;
        }
        direction = currentTarget.position - transform.position;

        float magnitude = direction.magnitude;

        normalizaDir = new Vector3(direction.x /magnitude, 
                                     direction.y /magnitude, 
                                        direction.z /magnitude);

        transform.position += normalizaDir * Time.deltaTime * speed;
        
    }
}
