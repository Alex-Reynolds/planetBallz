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
}
