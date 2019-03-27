using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    int gameballs = 0;
    private Vector3 initialposition;
    public GameObject theball;
    public GameObject endgame;
    private bool totallyover=false;

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
        if (gameballs < 1)
        {
            if (collider.gameObject == theball)
            {
                Debug.Log("game over");
                if (!totallyover)
                {
                    theball.transform.position = initialposition;
                    gameballs += 1;
                }


            }
        }
        else
        {
            //game is over
            endgame.SetActive(true);
            totallyover = true;
            if (totallyover)
            {
                this.GetComponent<AudioSource>().Play();
                Debug.Log("game Totally over");
            }
        }
    }
}
