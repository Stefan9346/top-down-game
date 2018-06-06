using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text gamestatus;
    private int numberOfEnemiesAlive;
    private int lastArraySize;


    void Start()
    {
        numberOfEnemiesAlive = 0;
    }

    void Update()
    {

        EnemiesAlive();
    }


    void EnemiesAlive()
    {
        numberOfEnemiesAlive = (GameObject.FindGameObjectsWithTag("Enemy")).Length;
        if (numberOfEnemiesAlive != lastArraySize)
        {
            gamestatus.text = gamestatus.text.Substring(0, 19);
            gamestatus.text = gamestatus.text + numberOfEnemiesAlive;

        }

        if (GameObject.FindGameObjectWithTag("Door").activeInHierarchy == true)
        {
            gamestatus.text = "The Door Has Spawned";
        }


    }
}
