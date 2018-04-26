using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{


    public float health;
    public float damage;
    public Color damagedColor;


    private SpriteRenderer sp;

    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private IEnumerator Waiter()
    {
        yield return new WaitForSeconds(0.225f);

        sp.color = new Color(1.000f, 1.000f, 1.000f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            ProjectileBehaviour projBehaviour = collision.gameObject.GetComponent<ProjectileBehaviour>();
            health -= projBehaviour.damage;
            sp.color = damagedColor;
            StartCoroutine(Waiter());
            Destroy(projBehaviour.gameObject);
        }
    }
}
