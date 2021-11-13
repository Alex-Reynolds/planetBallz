using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alian : MonoBehaviour
{

    public GameObject next;

   float distX;
   float distY;
   float distZ;

   float speed = .01F;

    


    // Update is called once per frame
    void Update()
    {
        
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + (distX * speed),gameObject.transform.position.y + (distY * speed), gameObject.transform.position.z + (distZ * speed)); 
       
    }

    public void setNext(GameObject next_point){


            next = next_point;

            distX = next.transform.position.x - gameObject.transform.position.x;
            distY = next.transform.position.y - gameObject.transform.position.y;
            distZ = next.transform.position.z - gameObject.transform.position.z;
            
            float distance = Vector3.Distance(transform.position, next.transform.position);

            distX = distX/distance;
            distY = distY/distance;
            distZ = distZ/distance;

    }
}
