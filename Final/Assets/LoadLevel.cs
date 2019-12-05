using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{




    void OnCollisionEnter(Collision col)
    {

        Debug.Log("Have not entered");
        //Debug.Log("startinghealth" + health);
        //Debug.Log(collisions.gameObject.name);
        Debug.Log(col.gameObject.name);
        if (col.gameObject.tag == "portal")
        {
            Debug.Log("Have entered Collision");

            SceneManager.LoadScene("ghost boss");

        }


    }
}
