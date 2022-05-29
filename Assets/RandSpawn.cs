using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSpawn : MonoBehaviour
{
    public GameObject[] prefeb;
    public GameObject[] cheesePool;
    public GameObject prefebspawned;
    public GameObject cheeseInstance;
    public GameObject ghostInstance;
    public GameObject fillerInstance;
    public int randnum;
    public int CheeseProbability = 90;
    public int GhostProbability = 1;
    public string type = "Filler";
    
    // Start is called before the first frame update
    void Awake()
    {

        cheeseInstance = Instantiate(prefeb[0], transform.position, Quaternion.identity) as GameObject;
        cheeseInstance.transform.parent = this.transform;
        cheeseInstance.transform.gameObject.SetActive(false);
        ghostInstance = Instantiate(prefeb[1], transform.position, Quaternion.identity) as GameObject;
        ghostInstance.transform.parent = this.transform;
        ghostInstance.transform.gameObject.SetActive(false) ;
        fillerInstance = Instantiate(prefeb[2], transform.position, Quaternion.identity) as GameObject;
        fillerInstance.transform.parent = this.transform;
        fillerInstance.transform.gameObject.SetActive(false) ;
        prefebspawned = fillerInstance;
    }
    private void OnEnable()
    {
        RandomSpawnItem();
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.parent.position;


    }

    public void RandomSpawnItem()
    {
        prefebspawned.transform.gameObject.SetActive(false);
        randnum = Random.Range(0, 100);
        if (randnum <= CheeseProbability && randnum > GhostProbability)
        {
            prefebspawned = cheeseInstance;
            
            prefebspawned.transform.gameObject.SetActive(true);
            type = "Cheese";
        }
        else if (randnum <= GhostProbability)
        {
            prefebspawned = ghostInstance;
            
            type = "Ghost";
            prefebspawned.transform.gameObject.SetActive(true);
        }
        else
        {
            prefebspawned = fillerInstance;
            
            type = "Filler";
            prefebspawned.transform.gameObject.SetActive(true);
        }

       
    }

}
