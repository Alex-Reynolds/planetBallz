using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billboard : MonoBehaviour
{
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(camera.transform, Vector3.up);
        Debug.Log(transform.rotation);
    }
}
