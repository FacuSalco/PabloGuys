using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgujaBehaviour : MonoBehaviour
{
    float rotationspeed;

     void Start()
    {
        rotationspeed = 2.5f;
    }


    void Update()
    {
        transform.Rotate(0, 0, rotationspeed);
    }
}
