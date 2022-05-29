using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 pos;
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.left;
        if (transform.position.x < -15)
        {
            transform.position = pos;
        }
    }
}
