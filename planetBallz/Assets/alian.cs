using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class alian : MonoBehaviour
{

    public GameObject next;

   float distX;
   float distY;
   float distZ;

   float speed = .01F;

   bool mouseClicked = false;

    
    void OnCollisionEnter (Collision collision) {
 
    if (collision.gameObject.name.Substring(0,5) == "alian" || collision.gameObject.name.Substring(0,6) == "pireta") {
        Physics.IgnoreCollision(collision.collider, gameObject.GetComponent<Collider>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        try {
            this.setNext(next);
        } catch (UnassignedReferenceException e){

        }
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + (distX * speed),gameObject.transform.position.y + (distY * speed), gameObject.transform.position.z + (distZ * speed)); 
       
        if (Input.GetMouseButton(0) && !mouseClicked) {
  	        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
   	        RaycastHit hit;
   	        // Casts the ray and get the first game object hit
   	        Physics.Raycast(ray, out hit);
            try {
   	            kill_ball(hit.collider.gameObject);
            } catch (NullReferenceException e) {

            }
            mouseClicked = true;
        }

        if (!Input.GetMouseButton(0)){
            mouseClicked = false;
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
        if (g.name.Substring(0,5) == "alian" || g.name.Substring(0,6) == "pireta"){
            Destroy(g);
            FindObjectOfType<AudioManager>().Play("GeneralDeathSound");
            if (g.name.Substring(0, 5) == "alian")
            {
                System.Random rand = new Random();
                double randValue = rand.NextDouble();

                if (randValue < 0.01)
                {
                    FindObjectOfType<AudioManager>().Play("PirateDeathRare");
                }
                else if (randValue < 0.15)
                {
                    FindObjectOfType<AudioManager>().Play("PirateDeath1");
                }
                else if (randValue < 0.3)
                {
                    FindObjectOfType<AudioManager>().Play("PirateDeath2");
                }
            }
            else if (g.name.Substring(0, 6) == "pireta")
            {
                System.Random rand = new Random();
                double randValue = rand.NextDouble();

                if (randValue < 0.1)
                {
                    FindObjectOfType<AudioManager>().Play("CowboyDeath1");
                }
                else if (randValue < 0.2)
                {
                    FindObjectOfType<AudioManager>().Play("CowboyDeath2");
                }
                else if (randValue < 0.3)
                {
                    FindObjectOfType<AudioManager>().Play("CowboyDeath3");
                }
            }

        }
    }
}
