using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public AudioClip clip;

    // Start is called before the first frame update

    //var for ScoreHandler
    public ScoreHandler scoreHandler; //scoreHandler is the variable name

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the other object is the projectile by its tag
        if (collision.tag == "Laser")
        {
            print("I'm Hit");

            // Allows playing an audio clip even if the Alien is destroyed and removed from the scene
            AudioSource.PlayClipAtPoint(clip, Vector2.zero);

            // Destroy the Alien game object (the one this script is on)
            Destroy(gameObject);
            scoreHandler.updateScore(100);

            // Destroy the projectile game object
            Destroy(collision.gameObject);

            //Add a point after every enemy destroyed
            //scoreHandler.score += 1;
        }
    }
}
