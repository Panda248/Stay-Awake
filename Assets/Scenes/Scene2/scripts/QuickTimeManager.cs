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

    [SerializeField]
    List<AudioClip> audioClipList = new List<AudioClip>();

    

    private AudioSource audioSource;
    private int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
            int i = 0;
            while(i < events.Count && newQT == null)
            {
                if (rng < chances[i])
                {
                    newQT = Instantiate<GameObject>(events[i]);
                    newQT.transform.SetParent(gameObject.transform);
                    newQT.gameObject.SetActive(true);
                    audioSource.clip = audioClipList[Random.Range(0, audioClipList.Count)];
                    audioSource.Play();
                }
                rng -= chances[i];
                i++;
            }
        }
    }
}
