using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float MIN_SIZE = 2.0f;
    float MAX_SIZE = 5.0f;

    public float rotatespeed = 3.5f;
    private int dir = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localScale += new Vector3(0.0f, 0.0f, 0.01f * dir);

        if (transform.localScale.z > MAX_SIZE)
        {
            dir = -1;
        }
        else if (transform.localScale.z < MIN_SIZE)
        {
            dir = 1;
        }
    }
}
