using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMouseLook : MonoBehaviour
{

    Vector2 rotation = Vector2.zero;
    Vector2 rbRotation = Vector2.zero;
	public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rbRotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        if(rotation.x*speed > 90)
        {
            rotation.x = 90/speed;
        }
        if(rotation.x*speed < -90)
        {
            rotation.x = -90/speed;
        }
        transform.eulerAngles = (Vector2)rotation * speed;
        transform.parent.transform.eulerAngles = rbRotation * speed; 
    }
}
