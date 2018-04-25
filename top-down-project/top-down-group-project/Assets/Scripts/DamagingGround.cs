using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingGround : MonoBehaviour {





	void Start () {
		
	}
	

	void Update () {
		
	}
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<Health>().health -= 1;
        }
    }
}
