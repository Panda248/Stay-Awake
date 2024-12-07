using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    ParticleSystem particles;
    AudioSource audioSource;
    MeshRenderer cube;
    // Start is called before the first frame update
    void Start()
    {
        particles = GetComponentInChildren<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
        cube = transform.GetChild(1).GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particles.Play();
            if (Random.Range(0f, 1f) < 0.1f) 
            { 
            audioSource.Play();
            }
            cube.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particles.Stop();
            cube.enabled = false;
        }
    }
}
