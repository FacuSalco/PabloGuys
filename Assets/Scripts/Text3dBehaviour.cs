using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text3dBehaviour : MonoBehaviour
{
    //public Text timer;
    float segundos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PauseScript.pausa == false)
        {
            segundos = float.Parse(PlayerCollision._timer.text);
            //Pregunar porque me aparce el error (anda igual) en Unity que dice
            //[FormatException: Input string was not in a correct format]

            if (segundos % 2 != 0)
            {
            transform.Translate(0, 0.01f, 0);
            }

            else if (segundos % 2 == 0)
            {
            transform.Translate(0, -0.01f, 0);
            }
        }
        
    }
}
