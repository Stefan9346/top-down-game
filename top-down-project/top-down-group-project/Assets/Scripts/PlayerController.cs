using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public Projectile proj;
    


    Animator myanim;



    void Start()
    {
        myanim = GetComponent<Animator>();

        proj = gameObject.GetComponent<Projectile>();
    }


    void Update()
    {
        //Right
        if (Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            myanim.SetBool("walking_right", true);
            myanim.SetBool("walking_up", false);
            myanim.SetBool("walking_down", false);
            myanim.SetBool("walking_left", false);

            proj.velocity = new Vector2(5, 0f);

        }

        //Left
        if (Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            myanim.SetBool("walking_left", true);
            myanim.SetBool("walking_up", false);
            myanim.SetBool("walking_down", false);
            myanim.SetBool("walking_right", false);

            proj.velocity = new Vector2(-5, 0f);
        }

        //Down
        if (Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            myanim.SetBool("walking_down", true);
            myanim.SetBool("walking_up", false);
            myanim.SetBool("walking_right", false);
            myanim.SetBool("walking_left", false);

            proj.velocity = new Vector2(0f, -5f);
        }

        //Up
        if (Input.GetAxisRaw("Vertical") > 0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            myanim.SetBool("walking_up", true);
            myanim.SetBool("walking_right", false);
            myanim.SetBool("walking_left", false);
            myanim.SetBool("walking_down", false);

            proj.velocity = new Vector2(0f, 5f);
        }
    }
}