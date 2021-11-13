using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_camera : MonoBehaviour
{
    float smooth = 5.0f;

    double distX;
    double distY;
    double distZ;

    float rotationX;
    float rotationY;
    float rotationZ;

    bool downDown = false;
    bool upDown = false;
    bool leftDown = false;
    bool rightDown = false;

    public GameObject planet;

     void Start(){
         distX = gameObject.transform.position.x - planet.transform.position.x;
        distY = gameObject.transform.position.y - planet.transform.position.z;
         distZ = gameObject.transform.position.z - planet.transform.position.z;

    }

    void Update() 
     {
         //ULTRA JANK
         
         if (Input.GetKeyDown(KeyCode.DownArrow)){
             downDown = true;
         }

          if (Input.GetKeyDown(KeyCode.UpArrow))
         {
             upDown = true;
        }

         if (Input.GetKeyDown(KeyCode.LeftArrow))
         {
             leftDown = true;
         }

          if (Input.GetKeyDown(KeyCode.RightArrow))
         {
             rightDown = true;
         }



         if (downDown){
           transform.RotateAround(planet.transform.position, Vector3.left, 80 * Time.deltaTime);
         }

         if (upDown){
          transform.RotateAround(planet.transform.position, Vector3.right, 80 * Time.deltaTime);
         }

         if (leftDown){
          transform.RotateAround(planet.transform.position, Vector3.up, 80 * Time.deltaTime);
         }
    
         if (rightDown){
          transform.RotateAround(planet.transform.position, Vector3.down, 80 * Time.deltaTime);
         }


          if (Input.GetKeyUp(KeyCode.DownArrow))
         {
             downDown = false;
         }

          if (Input.GetKeyUp(KeyCode.UpArrow))
         {
             upDown = false;
         }

         if (Input.GetKeyUp(KeyCode.LeftArrow))
         {
             leftDown = false;
         }

          if (Input.GetKeyUp(KeyCode.RightArrow))
         {
             rightDown = false;
         }

        
    }
}
