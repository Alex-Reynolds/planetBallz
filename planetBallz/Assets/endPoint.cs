using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endPoint : Point_Script
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Substring(0,5) == "alian"){

            alian other_other = other.gameObject.GetComponent<alian>();

             if (other_other.next.Equals(gameObject)){
                Destroy(other.gameObject);     
             }
            
        }
    }
}
