using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCamera : MonoBehaviour
{
    public float orthoChance = 0.1f;


    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        if (Random.value < orthoChance)
        {
            cam.orthographic = true;
        }
        else
        {
            cam.orthographic = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
