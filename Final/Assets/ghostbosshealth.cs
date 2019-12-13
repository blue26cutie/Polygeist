using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ghostbosshealth : MonoBehaviour
{

    public static int healthValue;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        healthValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
        // Set up the reference.
        anim = GetComponent<Animator>();
    }



    void OnCollisionEnter(Collision collision)
    {

       
        

        if (collision.gameObject.tag == "flarebullet")
        {

            Debug.Log("Flare bullet hit");
       

            anim.Play("BiteAttack");

            if (ghostbosshealth.healthValue == 0)
            {
                anim.Play("Die");
                Destroy(collision.gameObject);
                Debug.Log("Destroyed  " + collision.gameObject.name);

            }
            //anim.SetTrigger("Die");

            //transform.localScale -= new Vector3(x, y, z);


            //Debug.Log("ghost size: " + gameObject.GetComponent<Renderer>().bounds.size.x);

        }

    }
}
