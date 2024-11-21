using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private AudioSource audioSource;

    // Assign an audio clip in the Inspector or dynamically at runtime
    public AudioClip clipToPlay;

    void Start()
    {
        // Get or add an AudioSource component
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the clip to the AudioSource if available
        if (clipToPlay != null)
        {
            audioSource.clip = clipToPlay;
        }
        else
        {
            Debug.LogError("No AudioClip assigned to PlaySoundOnTouch script!");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object collided with has the "AJ" tag
        if (collision.gameObject.CompareTag("AJ"))
        {
            PlayAudio();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the trigger object has the "AJ" tag
        if (other.CompareTag("AJ"))
        {
            PlayAudio();
        }
    }

    private void PlayAudio()
    {
        if (audioSource != null && audioSource.clip != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource or AudioClip is missing!");
        }
    }
}
