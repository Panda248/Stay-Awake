using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPressEvent : QuickTimeEvent
{
    

    [SerializeField]
    public KeyCode key = KeyCode.Alpha2;

    

    [SerializeField]
    List<KeyCode> possibleKeys = new();

    [SerializeField]
    List<Sprite> keySprites = new();

    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();

        transform.position = new Vector3(Random.Range(0,Screen.width*0.8f), Random.Range(0,Screen.height*0.8f), 0);

        int index = Random.Range(0, keySprites.Count);
        image.sprite = keySprites[index];
        key = possibleKeys[index];
    }
    //TODO ASSIGN IMAGE BASED OFF KEY
    

    private void Update()
    {
        if(Input.GetKeyDown(key) && active)
        {
            playWin();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer-- <= 0 && active)
        {
            playLose();
        }
    }
}
