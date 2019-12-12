using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPortal : MonoBehaviour
{
    public int scoreVal = 1;
    public GameObject portal;
    // Start is called before the first frame update
    void Start()
    {
        portal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreManager.score == scoreVal)
        {
            spawnPortal();
        }
    }

    void spawnPortal()
    {

        portal.SetActive(true);
        //Debug.Log("portal active");
    }
}
