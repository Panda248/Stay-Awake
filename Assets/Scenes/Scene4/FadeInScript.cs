using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInScript : MonoBehaviour
{
    Image img;
    [SerializeField]
    float fadeSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Color color = img.color;
        color.a -= fadeSpeed;
        img.color = color;
    }
}
