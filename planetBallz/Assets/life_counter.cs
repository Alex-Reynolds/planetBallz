using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life_counter : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
           Text t = gameObject.GetComponent<Text>(); 
           t.text = (endPoint.lives + " lives left");
        

    }
}
