using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alian : MonoBehaviour
{

    public GameObject next;

    float distX;
    float distY;
    float distZ;

    float speed = 1F;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.Equals(next)){

            Point_Script old = collision.gameObject.GetComponent<Point_Script>();

            next = old.getNext().gameObject;
            setNext(next);
            }    
    }


    // Update is called once per frame
    void Update()
    {

        //TODO figure out why distX Y and Z are being zeroed out after one run of this loop
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + (distX * speed),gameObject.transform.position.y + (distY * speed), gameObject.transform.position.z + (distZ * speed)); 
    }

    public void setNext(GameObject next_point ){

            next = next_point;

            distX = gameObject.transform.position.x - next.transform.position.x;
            distY = gameObject.transform.position.y - next.transform.position.y;
            distZ = gameObject.transform.position.z - next.transform.position.z;
            
            float distance = Vector3.Distance(transform.position, next.transform.position);

            distX = distX/distance;
            distY = distY/distance;
            distZ = distZ/distance;
    }
}
