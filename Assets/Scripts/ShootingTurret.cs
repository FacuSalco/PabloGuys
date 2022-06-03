using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTurret : MonoBehaviour
{
    public GameObject bulletPrefab;
    float rateOfFire = 1f, fireRateDelta;

    void Update()
    {
        fireRateDelta -= Time.deltaTime;
        if (fireRateDelta <= 0)
        {
            Fire();
            fireRateDelta = rateOfFire;
        }

    }

    public void Fire()
    {

        if (PauseScript.pausa == false)
        { GameObject clon;
        clon = Instantiate(bulletPrefab, transform.position, transform.rotation);
        //Destroy(clon, destroyTime);
        }
    }

}