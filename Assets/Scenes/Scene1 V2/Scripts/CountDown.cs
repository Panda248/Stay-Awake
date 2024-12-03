using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text countdownText; // Assign your Text UI element here
    public float delayBetweenNumbers = 1f; // Time delay between each number

    void Start()
    {
        StartCoroutine(CountdownRoutine());
    }

    IEnumerator CountdownRoutine()
    {
        // Pause the game
        Time.timeScale = 0f;

        // Countdown sequence
        string[] countdownSequence = { "3", "2", "1", "GO" };
        foreach (string count in countdownSequence)
        {
            countdownText.text = count;
            countdownText.gameObject.SetActive(true); // Ensure text is visible
            yield return StartCoroutine(WaitForRealtime(delayBetweenNumbers));
        }

        // Hide countdown text
        countdownText.gameObject.SetActive(false);

        // Resume the game
        Time.timeScale = 1f;
    }

    IEnumerator WaitForRealtime(float seconds)
    {
        float start = Time.realtimeSinceStartup;
        while (Time.realtimeSinceStartup < start + seconds)
        {
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
