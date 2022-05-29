using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Text timer, gameOver, gameOverR;
    public GameObject player, camara, reloj, PlatTrap1, PlatTrap2, PlatTrap3, PlatTrap4, PlatTrap5, PlatTrap6, txtcheckpoint1;
    float tiempo = 60, restarSegundos = 10, tiempotrampa = 0;
    float spawnx, spawny, spawnz;//Cambiar para que sean las variables donde spawnee y crear nuevas para hacer checkpoints
    public Material rosa;
    int i1, i2, i3, i4, i5, i6;

    void Start()
    {
        gameOverR.text = "";
        spawnx = 0;
        spawny = 1.6f;
        spawnz = 0;

    }

    void Update()
    {
        tiempo -= Time.deltaTime;
        timer.text = tiempo.ToString("f0");

        if (transform.position.y < 0)
        {
            transform.position = new Vector3(spawnx, spawny, spawnz);
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
            transform.position = new Vector3(spawnx, spawny, spawnz);
            transform.eulerAngles = new Vector3(0, 0, 0);
            tiempo -= restarSegundos;
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
                transform.position = new Vector3(spawnx, spawny, spawnz);
                transform.eulerAngles = new Vector3(0, 0, 0);
               
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
                transform.position = new Vector3(spawnx, spawny, spawnz);
                transform.eulerAngles = new Vector3(0, 0, 0);
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
                transform.position = new Vector3(spawnx, spawny, spawnz);
                transform.eulerAngles = new Vector3(0, 0, 0);
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
                transform.position = new Vector3(spawnx, spawny, spawnz);
                transform.eulerAngles = new Vector3(0, 0, 0);
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
                transform.position = new Vector3(spawnx, spawny, spawnz);
                transform.eulerAngles = new Vector3(0, 0, 0);
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
                transform.position = new Vector3(spawnx, spawny, spawnz);
                transform.eulerAngles = new Vector3(0, 0, 0);
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

    }
}
