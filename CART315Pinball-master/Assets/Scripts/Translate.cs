using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    public float rotatespeed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.localPosition.y > 0)
        {
            transform.localPosition -= new Vector3(0, 0, 0.01f);

        }
    }
}
