using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endPoint : Point_Script
{   
   static int lives = 3;

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name.Substring(0,5) == "alian" || other.gameObject.name.Substring(0,6) == "pireta"){

            alian other_other = other.gameObject.GetComponent<alian>();
          if (other_other.next.Equals(gameObject)){

             lives = lives - 1;

            if (lives == 0){
              SceneManager.LoadScene(2);
            }
                Destroy(other.gameObject);     
             }
            
        }
    }
}
