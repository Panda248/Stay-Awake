using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionTimer : MonoBehaviour
{
    [SerializeField]
    int timer = 1000;
    [SerializeField]
    string ending;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer-- <= 0)
        {
            SceneManager.LoadScene(ending);
        }
    }
}
