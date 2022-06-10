using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorWall : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "CapsulePlayer")
        {
            if (PlayerCollision._player.GetComponent<Renderer>().material.color == GetComponent<Renderer>().material.color)
            {
                Destroy(gameObject, 0);
                GameObject clon;
                clon = Instantiate(PlayerCollision._destroySound);
                Destroy(clon, 0.5f);
            }
            
        }
    }
}
