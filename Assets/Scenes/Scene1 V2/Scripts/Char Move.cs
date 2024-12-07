using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{

    Vector3 temPos;
    int speed = 15;
    bool slowed = false;

    [SerializeField] private float minZ = -4f;
    [SerializeField] private float maxZ = 4f;

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

        Vector3 currentPosition = transform.position;
        currentPosition.z = Mathf.Clamp(currentPosition.z, minZ, maxZ);
        transform.position = currentPosition;

    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Building")
        {
            GameBehavior.Instance.sceneToMoveTo();
            Debug.Log("Hello World, Welcome to C#!");
        }

        if (other.gameObject.tag == "AJ" && !slowed)
        {
            speed = 5;
            slowed = true;
            StartCoroutine(ResetSpeed());
        }

        IEnumerator ResetSpeed()
        {
            yield return new WaitForSeconds(2);
            speed = 15;
            slowed = false;
        }

    }
}
