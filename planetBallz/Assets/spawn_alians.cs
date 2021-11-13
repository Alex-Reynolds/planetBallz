using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_alians : MonoBehaviour
{
    int timer = 0;
    public GameObject type;
    public GameObject first;

    // Update is called once per frame
    void Update()
    {

        timer = timer + 1;
        if (timer > 60){
            timer = 0;
            type = Instantiate(type, this.transform.position, Quaternion.identity);
            alian new_alian = type.GetComponent<alian>();
            new_alian.setNext(first);
           
         }
        
    }
}
