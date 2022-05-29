using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 0.1f, rotationSpeed = 4f, jumpForce;
    public Rigidbody rb;
    bool hasJump;
    public GameObject CamaraNormal, CamaraSprint;

    //GetComponent<Renderer>().material = rosa;
    //para cambiar de material

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hasJump = true;
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            CamaraSprint.SetActive(true);
            CamaraNormal.SetActive(false);
            movementSpeed = 0.15f;
        }
        else
        {
            CamaraSprint.SetActive(false);
            CamaraNormal.SetActive(true);
            movementSpeed = 0.1f;
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