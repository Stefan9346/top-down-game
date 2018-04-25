using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float seconds = 3;
    public float damage;

    void Start()
    {

    }

    void Update()
    {
        if (seconds > 0)
        {
            seconds -= Time.deltaTime;

        }


        else
        {
            DestroyObject(this.gameObject);
        }
    }
}