    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableBehaviour : MonoBehaviour
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
        if (PauseScript.pausa == false) //Si no esta pausado el juego
        {

            segundos = float.Parse(PlayerCollision._timer.text);

            if (segundos % 2 != 0)
            {
                transform.Translate(0 ,0.01f, 0);
            }

            else if (segundos % 2 == 0)
            {
                transform.Translate(0, -0.01f, 0);
            }
        }



    }



}
