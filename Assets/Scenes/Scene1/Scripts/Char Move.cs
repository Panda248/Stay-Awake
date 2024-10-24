using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 2 * Time.deltaTime);
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
