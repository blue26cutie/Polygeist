using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSize : MonoBehaviour
{
    public float x = 0.1f;
    public float y = 0.1f;
    public float z = 0.1f;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "ghost boss")
        {
            transform.localScale -= new Vector3(x, y, z);
        }
    }
}
