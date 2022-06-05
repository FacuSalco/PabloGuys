using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed, rotationSpeed, jumpForce;
    public Rigidbody rb;
    bool hasJump;
    public GameObject CamaraNormal, CamaraSprint, jumpSound;
    float movementSpeedNoShift, movementSpeedShift;

    //GetComponent<Renderer>().material = rosa;
    //para cambiar de material

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hasJump = true;
        movementSpeedNoShift = movementSpeed;
        movementSpeedShift = movementSpeed * 2;
    }

    void Update()
    {
        if (PauseScript.pausa == false)
        {

            if (Input.GetKey(KeyCode.LeftShift))
        {
            CamaraSprint.SetActive(true);
            CamaraNormal.SetActive(false);
            movementSpeed = movementSpeedShift;
        }
        else
        {
            CamaraSprint.SetActive(false);
            CamaraNormal.SetActive(true);
            movementSpeed = movementSpeedNoShift;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, movementSpeed);
            }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -movementSpeed);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && hasJump)
        {
            hasJump = false;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            GameObject clon;
            clon = Instantiate(jumpSound);
            Destroy(clon, 1);
        }
    }

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            hasJump = true;
        }

    }
}