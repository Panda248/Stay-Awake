using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpacityFilter : MonoBehaviour
{
    GamePlayLoop gamePlayLoop;
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        gamePlayLoop = FindObjectOfType<GamePlayLoop>();
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        image.color = new Color(0, 0, 0, gamePlayLoop.GetSleepyValue());
        Debug.Log(image.color.a);

    }
}
