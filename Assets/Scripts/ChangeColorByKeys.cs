using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorByKeys : MonoBehaviour
{
    public Material rosa, rojo, amarillo, naranja, verdeAgua, violeta;
    public GameObject colortxt;
    bool cambiarcolor;

    // Start is called before the first frame update
    void Start()
    {
        cambiarcolor = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cambiarcolor && PauseScript.pausa == false)
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
            GetComponent<Renderer>().material = rosa;
            }

            if (Input.GetKey(KeyCode.Alpha2))
            {
            GetComponent<Renderer>().material = rojo;
            }

            if (Input.GetKey(KeyCode.Alpha3))
            {
            GetComponent<Renderer>().material = amarillo;
            }

            if (Input.GetKey(KeyCode.Alpha4))
            {
            GetComponent<Renderer>().material = naranja;
            }

            if (Input.GetKey(KeyCode.Alpha5))
            {
            GetComponent<Renderer>().material = verdeAgua;
            }

            if (Input.GetKey(KeyCode.Alpha6))
            {
            GetComponent<Renderer>().material = violeta;
            }
        }
        

        if (PlayerCollision._player.transform.position.z > 200)
        {
            cambiarcolor = true;
            colortxt.SetActive(true);
        }
    }
}
