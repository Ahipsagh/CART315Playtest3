using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScoredInNet : MonoBehaviour
{
    public Score thescore;
    private Vector3 initialposition;
    public GameObject theball;
    private int timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        initialposition = theball.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer == 0)
        {
    //        this.GetComponent<ConstantForce>().enabled = false;
        }
        else
        {
            Debug.Log(timer);
            timer--;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == theball)
        {
            Debug.Log("Goal Scored");
            theball.transform.position = initialposition;
            theball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            this.GetComponent<AudioSource>().Play();
            thescore.AddScore(5);
            thescore.Addmultiplier(1);

        }

        //this.GetComponent<ConstantForce>().enabled = true;
        // timer = 3;
    }

}