﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string levelName;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //load level with scene name
            SceneManager.LoadScene(levelName);

            //restart level 1
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
