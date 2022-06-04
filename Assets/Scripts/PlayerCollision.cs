using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Text timer, gameOver, gameOverR;
    public GameObject player, camara, mainCamara, reloj, PlatTrap1, PlatTrap2, PlatTrap3, PlatTrap4, PlatTrap5, PlatTrap6, txtcheckpoint1, centerResetButton, topRightResetButton, pauseButton;
    float tiempo = 60, restarSegundos = 10, tiempotrampa = 0.5f;
    float spawnx, spawny, spawnz;
    public Material rosa;
    int i1, i2, i3, i4, i5, i6;
    public static GameObject _player;

    void Start()
    {
        gameOverR.text = "";
        spawnx = 0;
        spawny = 1.6f;
        spawnz = 0;
        _player = player;

    }

    void Update()
    {

        if (PauseScript.pausa == false)//Si no esta pausado el juego
        {
            tiempo -= Time.deltaTime;
            timer.text = tiempo.ToString("f0");
        }



        if (transform.position.y < -1)
        {
            respawn();
        }

        if (tiempo < 0) //CUANDO PIERDE
        {
            gameOver.text = "Game Over";
            gameOverR.text = "Game Over";
            player.SetActive(false);
            mainCamara.SetActive(true);
            centerResetButton.SetActive(true);
            topRightResetButton.SetActive(false);
            pauseButton.SetActive(false);

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

    void respawn()
    {
        transform.position = new Vector3 (spawnx, spawny, spawnz);
        transform.eulerAngles = new Vector3 (0, 0, 0);
        tiempo -= restarSegundos;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Damage")
        {
            respawn();
        }

        if (col.gameObject.tag == "ExtraTime")
        {
            tiempo = 60;
        }

        if (col.gameObject.name == "PlatTrap1")
        {
            PlatTrap1.GetComponent<Renderer>().material = rosa;
            if (i1 > 0)
            {
                Destroy(PlatTrap1, tiempotrampa);
            }

            else
            {
                respawn();
            }

            i1++;
        }

        if (col.gameObject.name == "PlatTrap2")
        {
            PlatTrap2.GetComponent<Renderer>().material = rosa;
            if (i2 > 0)
            {
                Destroy(PlatTrap2, tiempotrampa);
            }

            else
            {
                respawn();
            }

            i2++;
        }

        if (col.gameObject.name == "PlatTrap3")
        {
            PlatTrap3.GetComponent<Renderer>().material = rosa;
            if (i3 > 0)
            {
                Destroy(PlatTrap3, tiempotrampa);
            }

            else
            {
                respawn();
            }

            i3++;
        }

        if (col.gameObject.name == "PlatTrap4")
        {
            PlatTrap4.GetComponent<Renderer>().material = rosa;
            if (i4 > 0)
            {
                Destroy(PlatTrap4, tiempotrampa);
            }

            else
            {
                respawn();
            }

            i4++;
        }

        if (col.gameObject.name == "PlatTrap5")
        {
            PlatTrap5.GetComponent<Renderer>().material = rosa;
            if (i5 > 0)
            {
                Destroy(PlatTrap5, tiempotrampa);
            }

            else
            {
                respawn();
            }

            i5++;
        }

        if (col.gameObject.name == "PlatTrap6")
        {
            PlatTrap6.GetComponent<Renderer>().material = rosa;
            if (i6 > 0)
            {
                Destroy(PlatTrap6, tiempotrampa);
            }
            else
            {
                respawn();
            }

            i6++;
        }

        if (col.gameObject.tag == "CheckPoint1")
        {
            spawnx = 0;
            spawny = 5.01f;
            spawnz = 102.97f;
            txtcheckpoint1.SetActive(false);
        }

        if (col.gameObject.tag == "CheckPoint2")
        {
            spawnx = 0;
            spawny = 5.01f;
            spawnz = 132.86f;
        }

        if (col.gameObject.name == "PlatMedio")
        {
            txtcheckpoint1.SetActive(true);
        }

        if (col.gameObject.name == "RedBullet(Clone)" || col.gameObject.name == "YellowBullet(Clone)" || col.gameObject.name == "GreenBullet(Clone)")
        {
            respawn();
        }

    }
}
