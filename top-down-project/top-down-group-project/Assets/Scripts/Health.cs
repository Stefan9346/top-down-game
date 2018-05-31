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

    

    private AudioSource audiomanager;
    public AudioClip[] audioclips;


    void Start ()
    {
        health = 5;
        audiomanager = GetComponent<AudioSource>();
        
	}
	
	
	void Update ()
    {

        if(health > numOfHearts)
        {
            health = numOfHearts;
        }

        if(health < 1)
        {
            PlayerDead();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
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


    private void PlayerDead()
    {
        audiomanager.clip = audioclips[1];
        audiomanager.Play();

    }
 

    private void TakeDamage()
    {
        health--;
        audiomanager.clip = audioclips[0];
        audiomanager.Play();
    }


}
