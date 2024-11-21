using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTimeManager : MonoBehaviour
{

    [SerializeField]
    float qtPeriod = 100f;

    [SerializeField]
    List<GameObject> events = new List<GameObject>();
    [SerializeField]
    List<float> chances = new List<float>();

    private int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(timer++ >= qtPeriod)
        {
            timer = 0;
            GameObject newQT = null;
            float rng = Random.Range(0f, 1f);
            
            for (int i = 0; i < events.Count; i++)
            {
                Debug.Log(rng);
                if (rng < chances[i])
                {
                    newQT = Instantiate<GameObject>(events[i]);
                    newQT.transform.SetParent(gameObject.transform);
                    newQT.gameObject.SetActive(true);
                    return;
                }
                rng -= chances[i];

            }
        }
    }
}
