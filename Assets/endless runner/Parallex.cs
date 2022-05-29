using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallex : MonoBehaviour
{
    
    public Vector3 pos;
    public Vector3 speed=new Vector3(-0.5f,0,0);
    public float end=-15;
    // Start is called before the first frame update
    void Start()
    {
         pos= transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += speed;
        if (transform.position.x == end-2)
        {
            transform.position = pos;
        }
    }
}
