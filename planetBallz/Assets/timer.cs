using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class timer_script : MonoBehaviour
{

  
    int endTime;   

    // Start is called before the first frame update
    void Start()
    {
        DateTime dt = DateTime.Now;
        endTime = (dt.Second +  59)%60;
    }

    // Update is called once per frame
    void Update()
    {
        DateTime dt = DateTime.Now;
        if (dt.Second == endTime) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }


        if (dt.Second > endTime){
           Text t = gameObject.GetComponent<Text>(); 
           t.text = "OBJECTIVE SURVIVE for " + (dt.Second - endTime) + " more seconds";
        } else {
            Text t = gameObject.GetComponent<Text>();
            t.text = "OBJECTIVE SURVIVE for " + ((endTime + 59) - dt.Second) + " more seconds";
        }
        

    }
}
