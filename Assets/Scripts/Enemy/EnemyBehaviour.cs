using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public int increment;
    
    public AudioClip clip;

    public ScoreController scoreController;

   

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the other object is the projectile by its tag
        if (collision.tag == "Laser")
        {
            // Allows playing an audio clip even if the Alien is destroyed and removed from the scene
            AudioSource.PlayClipAtPoint(clip, Vector2.zero);

            // Destroy the Alien game object (the one this script is on)
            Destroy(gameObject);

            // Destroy the projectile game object
            Destroy(collision.gameObject);

            scoreController.updateScore(increment);   
        }
    }
}
