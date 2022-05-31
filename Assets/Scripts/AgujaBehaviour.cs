using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgujaBehaviour : MonoBehaviour
{
    float rotationspeed = 2.5f;

     void Start()
    {
        
    }


    void Update()
    {

        if (PauseScript.pausa == false) // Si el juego no esta en pausa
        {
            transform.Rotate(0, 0, rotationspeed);
        }
    }
}
