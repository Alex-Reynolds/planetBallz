using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endPoint : Point_Script
{   
   static int lives = 3;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Substring(0,5) == "alian" || other.gameObject.name.Substring(0,6) == "pireta"){

            alian other_other = other.gameObject.GetComponent<alian>();
            
             lives = lives - 1;

           //  m_MyText.text = "lives left: " + lives; 

             if (other_other.next.Equals(gameObject)){
                Destroy(other.gameObject);     
             }
            
        }
    }
}
