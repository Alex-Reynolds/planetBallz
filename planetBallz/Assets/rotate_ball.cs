using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

public class rotate_ball : MonoBehaviour
{

    float smooth = 5.0f;

    float tiltAroundY = 0;
    float tiltAroundX = 0;

    bool downDown = false;
    bool upDown = false;
    bool leftDown = false;
    bool rightDown = false;

    void Update()
    {
        //ULTRA JANK
         if (Input.GetKeyDown(KeyCode.DownArrow))
        {
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
             tiltAroundX = tiltAroundX - 1;
        }

        if (upDown){
            tiltAroundX = tiltAroundX + 1;
        }

        if (leftDown){
            tiltAroundY= tiltAroundY + 1;
        }
    
        if (rightDown){
            tiltAroundY = tiltAroundY - 1;
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

      
        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, tiltAroundY, 0);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);
    }
}
