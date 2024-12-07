using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextEvent : QuickTimeEvent
{
    [SerializeField]
    List<string> texts = new List<string>()
    {
        "Llorem Ipsum",
        "Yes Sir",
        "1+1=2",
        "Okay",
        "Pol Pot"
    };
    
    private TMP_InputField inputField;
    private TextMeshProUGUI textMesh;

    // Start is called before the first frame update
    void Awake()
    {
        inputField = transform.GetComponentInChildren<TMP_InputField>();
        textMesh = transform.GetChild(1).GetComponent<TextMeshProUGUI>();

        transform.position = new Vector3(Random.Range(0,Screen.width*0.8f), Random.Range(0,Screen.height*0.8f), 0);

        textMesh.text = texts[Random.Range(0, texts.Count)];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (inputField.text.Equals(textMesh.text) && active)
        {
            playWin();
        }
        if(timer-- <= 0 && active)
        {
            playLose();
        }
    }
}
