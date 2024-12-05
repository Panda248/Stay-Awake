using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableSpawner : MonoBehaviour
{
    public List<Transform> spawns = new List<Transform>();
    public GameObject interactableRef;
    public int interactableCount;
    private List<GameObject> interactablePool;
    // Start is called before the first frame update
    void Start()
    {
        interactablePool = new List<GameObject>();
        for (int i = 0; i < interactableCount; i++)
        {
            Debug.Log(i);
            Transform spawnObject = spawns[Random.Range(0, spawns.Count)];

            GameObject newInteract = Instantiate<GameObject>(interactableRef.gameObject, GeneratePosition(spawnObject), spawnObject.rotation);
            newInteract.transform.SetParent(gameObject.transform);
            interactablePool.Add(newInteract);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 GeneratePosition(Transform spawnArea)
    {
        float minX = spawnArea.position.x - (spawnArea.localScale.x / 2f);
        float minZ = spawnArea.position.z - (spawnArea.localScale.z / 2f);
        float maxX = spawnArea.position.x + (spawnArea.localScale.x / 2f);
        float maxZ = spawnArea.position.z + (spawnArea.localScale.z / 2f);
        float y = spawnArea.position.y;

        return new Vector3(Random.Range(minX, maxX), y, Random.Range(minZ, maxZ));
    }
}
