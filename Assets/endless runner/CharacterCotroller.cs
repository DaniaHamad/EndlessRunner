using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCotroller : MonoBehaviour
{
    public Rigidbody rb;
    public float push = 30f;
    public bool moving;
    public char letter = 'f';
    public float zes = -4.77f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector3.left * push * Time.deltaTime);
            
            //* push * Time.deltaTime
            //transform.position = new Vector3(-3.79f, -1.18f, -3.39f);

            //transform.position = Vector3.MoveTowards(transform.position, new Vector3(-3.79f, -1.18f, -3.39f), Time.deltaTime * push);
            //transform.position = Vector3.Lerp(transform.position, new Vector3(-3.79f, -1.18f, -3.39f), Time.deltaTime * push);
            moving = true;
            letter = 'A';
            rb.AddForce(Vector3.forward * push);
            if (zes < -4.76 && zes > -5.401)//middle
                zes = -3.39f;
            else if (zes <= -4.77f)//right
                zes = -4.77f;
            //if (moving)
            //{
            //    MoveTo(new Vector3(transform.position.x, transform.position.y, -3.27f));
            //    if (transform.position.x>11.8f)
            //        moving = false;
            //}


        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector3.right * push * Time.deltaTime);
            moving = true;
            letter = 'D';
            rb.AddForce(Vector3.back * push);
            if (zes <= -3.89 && zes > -5.401)//middle
                zes = -6.27f;
            else if (zes >= -3.89)//left
                zes = -4.77f;

        }
        //if (moving)
        //{
        //    CheckMovement(letter);

        //    //if (transform.position.z == zes)
        //    //    moving = false;

        //}

        //if (moving)
        //{
        //    CheckMovement(letter);
        //    if (transform.position.z > 11.8)
        //        moving = false;
        //}
        //void CheckMovement(char letter)
        //{
        //    switch (letter)
        //    {
        //        case 'A':
        //            MoveTo(new Vector3(transform.position.x, transform.position.y, zes));
        //            break;
        //        case 'D':
        //            MoveTo(new Vector3(transform.position.x, transform.position.y, zes));

        //            break;

        //    }
        //   // WaitFor();
        //}
        //void MoveTo(Vector3 newPosition)
        //{
        //    transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * push);

        //}
    }

    //void WaitFor()
    //{
    //    float timeRemaining = 50000f;
    //    while (timeRemaining > 0)
    //    {
    //        timeRemaining -= 1;
    //    }
        
    //}

}