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
        if (timer > 240){
            timer = 0;
            GameObject meme = Instantiate(type, gameObject.transform.position, Quaternion.identity);
            alian new_alian = meme.GetComponent<alian>();
            new_alian.setNext(first);
           
         }
        
    }
}
