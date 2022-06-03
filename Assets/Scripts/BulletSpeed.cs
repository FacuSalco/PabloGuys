using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    public float bulletSpeed = 5f;

    void Update()
    {
        if (PauseScript.pausa == false)
        {
            transform.Translate(new Vector3(bulletSpeed * Time.deltaTime, 0, 0));
        }

        if (transform.position.x > 15)
        {
            Destroy(gameObject, 0);
        }
    }
}
