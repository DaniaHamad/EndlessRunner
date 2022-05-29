using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTrigger : MonoBehaviour
{
    public static int counter = 0;
    GameObject spawnLoc; 
    Vector3 spawnPos;
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.tag.Equals("Player"))
        {
            if (transform.GetChild(0).GetComponent<RandSpawn>().type == "Cheese") 
            {
                counter++;

                spawnLoc.GetComponent<RandSpawn>().prefebspawned.SetActive(false);

                //spawnLoc.SetActive(false);
                //spawnLoc.SetActive(true);



            }
            else if(transform.GetChild(0).GetComponent<RandSpawn>().type =="Ghost")
            {
                Debug.Log("Collided with a ghost");
                //spawnLoc.SetActive(false);
                //spawnLoc.SetActive(true);
            }

        }        
    }


    void Awake()
    {
        spawnLoc = transform.GetChild(0).gameObject;
        spawnPos = transform.position;
    }

    void Update()
    { 
        spawnPos.x = transform.parent.position.x;
    }
}
