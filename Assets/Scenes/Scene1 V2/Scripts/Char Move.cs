using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{

    Vector3 temPos;
    int speed = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

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
        /*if(other.gameObject.tag == "AJ")
        {
            GameBehavior.Instance.sceneToMoveTo();
            Debug.Log("Hello World, Welcome to C#!");
        }*/

        if (other.gameObject.tag == "AJ")
        {
            speed = 5;
            StartCoroutine(ResetSpeed());
        }

        IEnumerator ResetSpeed()
        {
            yield return new WaitForSeconds(2);
            speed = 15;
        }

    }
}
