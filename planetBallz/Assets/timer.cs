using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class timer : MonoBehaviour
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

    }
}
