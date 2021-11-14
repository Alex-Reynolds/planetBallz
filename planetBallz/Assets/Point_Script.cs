using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_Script : MonoBehaviour
{

    public Point_Script next;


    public void setNext (Point_Script next){
        this.next = next;
    }

    public Point_Script getNext (){
        return next;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Substring(0,5) == "alian"){
            alian other_other = other.gameObject.GetComponent<alian>();

            if (other_other.next.Equals(gameObject)){
                other_other.setNext(getNext().gameObject);
            }
        }
    }
}
