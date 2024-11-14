using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScooterMove : MonoBehaviour
{
    int speed = 30;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 left = new Vector2(-1, 0);
        transform.Translate(left * speed * Time.deltaTime);
    }
}
