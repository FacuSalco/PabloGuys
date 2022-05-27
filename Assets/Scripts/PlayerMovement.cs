using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float movementSpeed = 0.1f, rotationSpeed = 4f;
    public float jumpForce;
    public Rigidbody rb;
    bool hasJump;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hasJump = true;
    }

    void Update()
    {
        Debug.Log(hasJump);
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

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(0, 0, 0.025f);
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
            Debug.Log("Esta tocando el piso");
        }
    }
}