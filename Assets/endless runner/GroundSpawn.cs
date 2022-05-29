using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    public GameObject[] floors;
    public List<GameObject> instanceFloors;
     GameObject floor;
     GameObject floor2;
    public int randnum1;
    public int randnum2;
    //public Vector3 pos;
    public Vector3 speed = new Vector3(-1f, 0, 0);
    public float end = -21f;


    // Start is called before the first frame update
    void Start()
    {


        randnum1 = Random.Range(0, 3);
        do
        {
            randnum2 = Random.Range(0, 3);
        } while (randnum1 != randnum2);

        foreach (var item in floors)
        {
            item.SetActive(false);

            instanceFloors.Add(Instantiate(item, transform.position, Quaternion.identity));


        }
        floor = instanceFloors[0];

        floor2 = instanceFloors[1];
        floor.SetActive(true);
        floor2.SetActive(true);
        floor.transform.position = this.transform.parent.transform.position;
        floor2.transform.position = this.transform.parent.transform.position + Vector3.left * -22;
    }

    // Update is called once per frame
    void Update()
    {
        floor.transform.position += speed;
        floor2.transform.position += speed;

        if (floor.transform.position.x == end)
        {
            floor.SetActive(false);
            //    floor = floor2;
            //    floor2 = instanceFloors[randnum2];
            //    floor2.SetActive(true);

            //floor = floor2;
            do
            {

                randnum2 = Random.Range(0, 3);
                floor = instanceFloors[randnum2];

                // floor2.GetComponent<RandSpawn>().RandomSpawnItem();


                floor.SetActive(true);
            } while (floor2 == floor);
            floor.transform.position = this.transform.parent.transform.position + Vector3.left * -22;
        }
        else if (floor2.transform.position.x == end)
        {

            floor2.SetActive(false);
            //    floor = floor2;
            //    floor2 = instanceFloors[randnum2];
            //    floor2.SetActive(true);

            //floor = floor2;
            do
            {

                randnum2 = Random.Range(0, 3);
                floor2 = instanceFloors[randnum2];

                // floor2.GetComponent<RandSpawn>().RandomSpawnItem();


                floor2.SetActive(true);
            } while (floor2 == floor);
            floor2.transform.position = this.transform.parent.transform.position + Vector3.left * -22;


        }
    }
}
