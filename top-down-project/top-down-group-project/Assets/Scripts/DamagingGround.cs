using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingGround : MonoBehaviour
{


    public float damageOverTime;



    void Start()
    {
       
    }


    void Update()
    {
       
    }


    //private void OnTriggerStay2D(Collider2D collision)
    //{

    //    if (damageOverTime > 0f)
    //    {
    //        damageOverTime -= Time.deltaTime;
    //    }

    //    else if (collision.transform.tag == "Player")
    //    {
    //        collision.gameObject.GetComponent<Health>().health -= 1;
    //        damageOverTime = 0.5f;

    //    }


    //}


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            damageOverTime -= Time.deltaTime;
            if (damageOverTime <= 0)
            {
                collision.gameObject.GetComponent<Health>().health -= 1;
                damageOverTime = 1f;
            }
        }
    }

}

