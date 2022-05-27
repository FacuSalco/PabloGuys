using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Text timer;
    public Text gameOver;
    public GameObject player, camara, reloj;
    float tiempo = 60, restarSegundos = 10;
    //Hacer para que cuando agarre unos cositos (relojistos en lo posible)
    //se sume la variable "sumarsegundos" al tiempo

    void Start()
    {
        gameOver.text = "";
    }

    void Update()
    {
        tiempo -= Time.deltaTime;
        timer.text = tiempo.ToString("f0");

        if (transform.position.y < -3)
        {
            transform.position = new Vector3(0, 1f, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
            tiempo -= restarSegundos;
        }

        if (tiempo <= 0)
        {
            gameOver.text = "Game Over";
            player.SetActive(false);
            camara.SetActive(true);
            timer.text = "";
            
        }

        if (tiempo < 20)
        {

            reloj.SetActive(true);

        }

        else if (tiempo > 20)
        {
            reloj.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Aguja")
        {
            transform.position = new Vector3(0, 1f, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
            tiempo -= restarSegundos;
        }

        if (col.gameObject.name == "Reloj")
        {
            tiempo = 60;
        }
    }
}
