using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Text timer;
    public Text gameOver, gameOverR;
    public GameObject player, camara, reloj, PlatTrap1, PlatTrap2, PlatTrap3, PlatTrap4, PlatTrap5, PlatTrap6;
    float tiempo = 60, restarSegundos = 10, tiempotrampa = 0;
    float spawn1x, spawn1y, spawn3z;//Cambiar para que sean las variables donde spawnee y crear nuevas para hacer checkpoints






    void Start()
    {
        gameOverR.text = "";

    }

    void Update()
    {
        tiempo -= Time.deltaTime;
        timer.text = tiempo.ToString("f0");

        if (transform.position.y < 0)
        {
            transform.position = new Vector3(0, 1f, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
            tiempo -= restarSegundos;
        }

        if (tiempo <= 0)
        {
            gameOver.text = "Game Over";
            gameOverR.text = "Game Over";
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
        if (col.gameObject.tag == "Damage")
        {
            transform.position = new Vector3(0, 1f, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
            tiempo -= restarSegundos;
        }

        if (col.gameObject.tag == "ExtraTime")
        {
            tiempo = 60;
        }

        if (col.gameObject.name == "PlatTrap1")
        {
            Destroy(PlatTrap1, tiempotrampa);
        }

        if (col.gameObject.name == "PlatTrap2")
        {
            Destroy(PlatTrap2, tiempotrampa);
        }

        if (col.gameObject.name == "PlatTrap3")
        {
            Destroy(PlatTrap3, tiempotrampa);
        }

        if (col.gameObject.name == "PlatTrap4")
        {
            Destroy(PlatTrap4, tiempotrampa);
        }

        if (col.gameObject.name == "PlatTrap5")
        {
            Destroy(PlatTrap5, tiempotrampa);
        }

        if (col.gameObject.name == "PlatTrap6")
        {
            Destroy(PlatTrap6, tiempotrampa);
        }
    }
}
