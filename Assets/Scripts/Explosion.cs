using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private ParticleSystem explosionParticleSystem;
    public GameObject triggerCube; // Reference to the Trigger Cube
    private bool isExplosionTriggered = false;
    private Vector3 explosionPosition; // Save Trigger Cube's position

    void Start()
    {
        // Get the ParticleSystem component on this GameObject
        explosionParticleSystem = GetComponent<ParticleSystem>();

        // Stop the particle system at the start
        if (explosionParticleSystem != null)
        {
            explosionParticleSystem.Stop();
        }
        else
        {
            Debug.LogError("Particle system not found on Explosion object");
        }
    }

    void Update()
    {
        // Check if Trigger Cube is still active and explosion hasn't triggered
        if (triggerCube != null)
        {
            // Save Trigger Cube's current position continuously
            explosionPosition = triggerCube.transform.position;
        }
        else if (!isExplosionTriggered)
        {
            // Trigger the explosion once when Trigger Cube is destroyed
            TriggerExplosion();
        }
    }

    void TriggerExplosion()
    {
        if (explosionParticleSystem != null)
        {
            // Move the particle system to the saved position
            transform.position = explosionPosition;

            // Start the particle system
            explosionParticleSystem.Play();

            // Set the flag to prevent repeated explosions
            isExplosionTriggered = true;
        }
    }
}