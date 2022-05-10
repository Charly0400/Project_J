using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curves1 : MonoBehaviour
{
    /* [Header("Petalo")]
    public Transform rotationCenter;
    public float angularDisplacement = 90;
    public float angularSpeed;
    public float rotationRadius = 5;
    public float angle = 0;
    public float Variante;
    public float positionX;
    public float positionY;
    public float positionZ; */


    /* [Header("Belnded Infinity")]
    public Transform rotationCenter;
    public float angularDisplacement = 90;
    public float angularSpeed;
    public float rotationRadius = 5;
    public float parameter = 0;
    public float positionX;
    public float positionY;
    public float positionZ; */


    /* [Header("Infiny projection (Curves no crosses with itsel")]
    public Transform rotationCenter;
    public float angularDisplacement = 90;
    public float angularSpeed;
    public float rotationRadius = 5;
    public float parameter = 0;
    public float positionX;
    public float positionY;
    public float positionZ; */


    /* [Header("Infity")]
    public Transform rotationCenter;
    public float angularDisplacement = 90;
    public float angularSpeed;
    public float rotationRadius = 5;
    public float parameter = 0;
    public float positionX;
    public float positionY;
    public float positionZ; */


    /* [Header("Espiral")]
    public Transform rotationCenter;
    public float angularDisplacement = 90;
    public float angularSpeed;
    public float rotationRadius = 5;
    public float width = 1;
    public float parameter = 0;
    public float positionX;
    public float positionY;
    public float positionZ; */


    /* [Header("Curl")]
    public Transform rotationCenter;
    public float angularDisplacement = 90;
    public float angularSpeed;
    public float rotationRadius = 5;
    public float width = 1;
    public float parameter = 0;
    public float positionX;
    public float positionY;
    public float positionZ; */


   [Header ("Circle")]
    public Transform rotationCenter;
    public float angularDisplacement = 90;
    public float angularSpeed;
    public float rotationRadius = 5;
    public float angle = 0;
    public float positionX;
    public float positionY;
    public float positionZ;  


    void Update()
    {
        //Circle
        angularSpeed = angularDisplacement * Mathf.Deg2Rad;
        positionX = rotationCenter.position.x;
        positionY = rotationCenter.position.y + rotationRadius * Mathf.Sin(angle);
        positionZ = rotationCenter.position.z + rotationRadius * Mathf.Cos(angle);
        transform.position = new Vector3(positionX, positionY, positionZ);
        angle += angularSpeed * Time.deltaTime;

        if (angle >= 360 * Mathf.Rad2Deg)
        {
            angle = 0;
        } 

        /*/Curl
        angularSpeed = angularDisplacement * Mathf.Deg2Rad;
        positionX = rotationCenter.position.x + rotationRadius * Mathf.Sin(parameter);
        positionY = rotationCenter.position.y + rotationRadius * Mathf.Cos(parameter);
        positionZ = rotationCenter.position.z + width * parameter;
        transform.position = new Vector3(positionX, positionY, positionZ);
        parameter += angularSpeed * Time.deltaTime;

        if (parameter >= 20 || parameter <= 0 )
        {
            angularDisplacement = -angularDisplacement;
        } */

        /*/Spiral
        angularSpeed = angularDisplacement * Mathf.Deg2Rad;
        positionX = rotationCenter.position.x + rotationRadius * parameter * Mathf.Sin(parameter);
        positionY = rotationCenter.position.y + rotationRadius * parameter * Mathf.Cos(parameter);
        positionZ = rotationCenter.position.z + width * parameter;
        transform.position = new Vector3(positionX, positionY, positionZ);
        parameter += angularSpeed * Time.deltaTime;

        if (parameter >= 20 || parameter <= -20)
        {
            angularDisplacement = -angularDisplacement;
        } */

        /*/Infinity
        angularSpeed = angularDisplacement * Mathf.Deg2Rad;
        positionX = rotationCenter.position.x + rotationRadius * Mathf.Sin(2 * parameter);
        positionY = rotationCenter.position.y + 2 *  rotationRadius * Mathf.Cos(parameter);
        positionZ = rotationCenter.position.z;
        transform.position = new Vector3(positionX, positionY, positionZ);
        parameter += angularSpeed * Time.deltaTime;

        if (parameter >= 360 * Mathf.Rad2Deg)
        {
            parameter = 0;
        } */

        /*/Infinity projection (curves no crosses itself)
       angularSpeed = angularDisplacement * Mathf.Deg2Rad;
       positionX = rotationCenter.position.x + rotationRadius * Mathf.Sin(parameter);
       positionY = rotationCenter.position.y + rotationRadius * Mathf.Sin(parameter) * Mathf.Cos(parameter);
       positionZ = rotationCenter.position.z + rotationRadius * Mathf.Cos(parameter);
       transform.position = new Vector3(positionX, positionY, positionZ);
       parameter += angularSpeed * Time.deltaTime;

       if (parameter >= 360 * Mathf.Rad2Deg)
       {
           parameter = 0;
       } */


        /*/Bended infinty
        angularSpeed = angularDisplacement * Mathf.Deg2Rad;
        positionX = rotationCenter.position.x + rotationRadius * Mathf.Pow(Mathf.Sin(parameter), 2);
        positionY = rotationCenter.position.y + rotationRadius * Mathf.Sin(parameter) * Mathf.Cos(parameter);
        positionZ = rotationCenter.position.z + rotationRadius * Mathf.Cos(parameter);
        transform.position = new Vector3(positionX, positionY, positionZ);
        parameter += angularSpeed * Time.deltaTime;

        if (parameter >= 360 * Mathf.Rad2Deg)
        {
            parameter = 0;
        } */




        /*/Petalo
        angularSpeed = angularDisplacement * Mathf.Deg2Rad;
        positionX = rotationCenter.position.x + rotationRadius * Mathf.Cos(Variante * angle) * Mathf.Sin(angle);
        positionY = rotationCenter.position.y + rotationRadius * Mathf.Cos(Variante * angle) * Mathf.Cos(angle);
        positionZ = rotationCenter.position.z;
        transform.position = new Vector3(positionX, positionY, positionZ);
        angle += angularSpeed * Time.deltaTime;

        if (angle >= 360 * Mathf.Rad2Deg)
        {
            angle = 0;
        } */
    }
}
