using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //gives access to UI elements

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;
    public Image[] livesUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //This is for when player collides with the enemy
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject); //Destroys enemy object 
            lives -= 1;

            //To check if the lives images need to be turned off when hit
            for (int i = 0; i < livesUI.Length; i++)
            {
                if (i < lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if (lives < 0)
            {
                Destroy(gameObject);
            }
        }
    }

    //checking if enemy projectile hits the player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject); //Destroys enemy object 
            lives -= 1;

            //To check if the lives images need to be turned off when hit
            for (int i = 0; i < livesUI.Length; i++)
            {
                if (i < lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if (lives < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
