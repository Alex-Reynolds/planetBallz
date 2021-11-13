using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
       
        if (Input.GetMouseButton(0)) {
  	        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
   	        RaycastHit hit;
   	        // Casts the ray and get the first game object hit
   	        Physics.Raycast(ray, out hit);
            try {
   	            kill_ball(hit.collider.gameObject);
            } catch (NullReferenceException e) {

            }
        }
       
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

      public void kill_ball(GameObject g){
        if (g.name.Substring(0,5) == "alian"){
            Destroy(g);
        }
    }
}
