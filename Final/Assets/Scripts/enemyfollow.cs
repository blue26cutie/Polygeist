using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfollow : MonoBehaviour
{
    public Transform Player;
    
    int MoveSpeed = 4;
    int MaxDist = 4;
    int MinDist = 0;




    void start()
    {
        
    }

    void Update()

    {

       
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
               
            }

        }
    }
}


