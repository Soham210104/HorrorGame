using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCast : MonoBehaviour
{
    public static float DistanceFromPlayer; //so need to create a reference for another scripts to use this variable
    public float ToTarget;//distance of ray hitting to the target..gives the distance b/w player and object

    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;
        // transform.position = position of the object to whom script is attach.
        //transform.TransformDirection(Vector3.forward) = In which direction the ray should be.
        //out Hit = output of Raycast Hit.
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Hit))
        {
            ToTarget = Hit.distance;
            DistanceFromPlayer = ToTarget;
        }
    }
}
