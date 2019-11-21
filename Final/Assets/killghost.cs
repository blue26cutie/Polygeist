using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killghost : MonoBehaviour
{

    public int scoreValue = 1;
    // Start is called before the first frame update
    Animator anim;
    void Awake()
    {
        // Set up the reference.
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "enemy"){

            Debug.Log("Hit the correct enemy tag");
            ScoreManager.score += scoreValue;
            Destroy(collision.gameObject);
            //anim.SetTrigger("Die");

            Debug.Log("Destroyed  " + collision.gameObject.name);
        }
        Debug.Log(collision.gameObject.name);
        
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
