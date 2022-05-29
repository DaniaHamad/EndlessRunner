using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        GameObject groundController = GameObject.Find("GroundController");
        GameObject next = groundController.transform.GetChild(15).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left;
        if (transform.position.x >= -11)
            print("filer");


    }
}
