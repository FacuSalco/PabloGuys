using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelojBehaviour : MonoBehaviour
{
    public Text timer;
    //bool par;
    float segundos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -1);

        segundos = float.Parse(timer.text);
        //Pregunar porque me aparce el error (anda igual) en Unity que dice
        //[FormatException: Input string was not in a correct format]

        if (segundos%2 != 0)
        {
            transform.Translate(0, 0, 0.01f);
        }

        else if (segundos%2 == 0)
        {
            transform.Translate(0, 0, -0.01f);
        }



    }



}
