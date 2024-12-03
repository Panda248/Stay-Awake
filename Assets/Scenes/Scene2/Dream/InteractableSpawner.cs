using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableSpawner : MonoBehaviour
{
    public List<Transform> spawns = new List<Transform>();
    public Interactable interactableRef;
    public int interactableCount;
    private List<Interactable> interactablePool;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < interactableCount; i++)
        {
            Transform spawnObject = spawns[Random.Range(0, spawns.Count)];

         // Interactable newInteract = Instantiate<Interactable>(interactableRef, new Vector3, new Quaternion( );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
