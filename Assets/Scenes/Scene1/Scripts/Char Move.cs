using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{

    Vector3 temPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 10 * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            Vector2 right = new Vector2(1, 0);
            transform.Translate(right * 7 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector2 left = new Vector2(-1, 0);
            transform.Translate(left * 7 * Time.deltaTime);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "AJ")
        {
            GameBehavior.Instance.sceneToMoveTo();
            Debug.Log("Hello World, Welcome to C#!");
        }
    }
}
