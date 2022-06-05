using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    int i;
    public GameObject gameOverSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerCollision.perdio && i == 0)
        {
            Instantiate(gameOverSound);
            i++;
        }
    }
}
