using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killghost : MonoBehaviour
{

    public int scoreValue = 1;
    public int bossHealth = 1;
    // Start is called before the first frame update
    Animator anim;
    //public float x = 5.0f;
    //public float y = 5.0f;
    //public float z = 5.0f;
    
    void Awake()
    {
        // Set up the reference.
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        
    }
    void Update()
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

        if (collision.gameObject.tag == "boss ghost")
        {

            Debug.Log("Hit BIG BOI");
            Debug.Log(ghostbosshealth.healthValue);
            ScoreManager.score += scoreValue;
            ghostbosshealth.healthValue -= bossHealth;

            
            
            

            if(ghostbosshealth.healthValue == 0)
            {
                //anim.Play("Die");
                Destroy(collision.gameObject);
                Debug.Log("Destroyed  " + collision.gameObject.name);

            }
            //anim.SetTrigger("Die");

            //transform.localScale -= new Vector3(x, y, z);

            
            //Debug.Log("ghost size: " + gameObject.GetComponent<Renderer>().bounds.size.x);

        }

    }


    
    // Update is called once per frame
    
}
