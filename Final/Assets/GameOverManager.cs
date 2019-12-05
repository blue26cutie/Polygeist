  using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameovercanvas;
    int health = 1;


   

          // Reference to the player's health.
    public float restartDelay = 5f;            // Time to wait before restarting the level


    Animator anim;                          // Reference to the animator component.
    float restartTimer;                     // Timer to count up to restarting the level


    void Start()
    {
        // Set up the reference.
     
        anim = gameovercanvas.GetComponent<Animator>();
    }
    void OnCollisionEnter(Collision collisions)
    {
        
        //Debug.Log("startinghealth" + health);
        //Debug.Log(collisions.gameObject.name);
        if (collisions.gameObject.tag == "enemy")
        {
           

            health--;

        }


    }

    void Update()
    {
        if (health <= 0)
        {

            //Debug.Log("Health is" + health);
            // ... tell the animator the game is over.
            //anim.SetTrigger("GameOver");
            anim.SetBool("IsGameOver", true);
            
               // Debug.Log("Set Bool to true");
            // .. increment a timer to count up to restarting.
            restartTimer += Time.deltaTime;

            // .. if it reaches the restart delay...
            if (restartTimer >= restartDelay)
            {
                // .. then reload the currently loaded level.
                SceneManager.LoadScene("Forest Scene");
            }
        }

    }
}

