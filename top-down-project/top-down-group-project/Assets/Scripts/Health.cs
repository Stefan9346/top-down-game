using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite heartFull;
    public Sprite heartEmpty;

    void Start ()
    {
        health = 8;
	}
	
	
	void Update ()
    {

        if(health > numOfHearts)
        {
            health = numOfHearts;
        }

        if(health < 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = heartFull;
            }
            else
            {
                hearts[i].sprite = heartEmpty;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

	}




  //  private void OnTriggerEnter2D(Collider2D collision)
   // {
    //    if (collision.transform.tag == "damageGround")
      //  {
        //    health -= 1;
     //   }
    //}
}
