using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{

    //  Me tira este error cuando intento cambiar el texto de este boton:
    //  NullReferenceException: Object reference not set to an instance of an object

    public static bool pausa;
    int counter, timespaused;

    void Start()
    {
        pausa = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Pausa();
            
        }
    }

    public void Pausa() //Cuando es IMPAR esta en pausa, cuando es PAR no esta en pausa
    {

        counter++;

        if (counter % 2 == 0) //Par se saca pausa
        {
            pausa = false;
            //GetComponent<Text>().text = "II";
        }

        else if (counter % 2 != 0) //Impar se pone pausa
        {
            pausa = true;
            //GetComponent<Text>().text = "▶";
        }
    }

}
