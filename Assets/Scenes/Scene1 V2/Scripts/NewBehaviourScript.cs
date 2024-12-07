using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{

    public float[] xValues = { 50f, 20f, 50f };

 
    public void SetRandomXPosition()
    {
        int randomIndex = Random.Range(0, xValues.Length);

        Vector3 newPosition = transform.position;
        newPosition.x = xValues[randomIndex];
        transform.position = newPosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetRandomXPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
