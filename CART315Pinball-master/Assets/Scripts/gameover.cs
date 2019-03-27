﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    int gameballs = 0;
    private Vector3 initialposition;
    public GameObject theball;
    public GameObject endgame;

    // Start is called before the first frame update
    void Start()
    {
        endgame.SetActive(false);
        initialposition = theball.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (gameballs < 3)
        {
            if (collider.gameObject == theball)
            {
                Debug.Log("game over");
                theball.transform.position = initialposition;
                gameballs += 1;
            }
        }
        else if (gameballs >=3)
        {
            //game is over
            endgame.SetActive(true);
            this.GetComponent<AudioSource>().Play();
            Debug.Log("game Totally over");
        }
    }
}
