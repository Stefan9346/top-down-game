using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {


    public float health;
    public float damage;


    private SpriteRenderer sp;



	void Start ()
    {
        sp = GetComponent<SpriteRenderer>();
	}
	
	
	void Update ()
    {
		if(health <= 0)
        {
            Destroy(this.gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
           ProjectileBehaviour projBehaviour = collision.gameObject.GetComponent<ProjectileBehaviour>();
            health -= projBehaviour.damage;
            Destroy(projBehaviour.gameObject);
        }
    }
}
