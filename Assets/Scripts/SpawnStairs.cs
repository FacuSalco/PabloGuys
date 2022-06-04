using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStairs : MonoBehaviour
{
    public GameObject escalon;
    float yOffset, zOffset;

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
            for (int i = 0; i < 1; i++)
            {
                yOffset += 0.35f;
                zOffset += 1f;
                Instantiate(escalon).transform.position += new Vector3(0, yOffset, zOffset);
                Debug.Log("Toca el player");
                Destroy(gameObject, 0.3f);
                
            }
            

        }
    }

}
