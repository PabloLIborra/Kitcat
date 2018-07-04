using PDollarGestureRecognizer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static Weapon[] weapons;
    public float ongoingTime;


    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        ongoingTime += Time.deltaTime;

        //Random activation condition
        if (ongoingTime > 1)
        {
            ongoingTime = 0;
            //Update weapon's charge
            for (int i = 0; i < weapons.Length; i++)
            {
                //If after adding a piece weapon is ready to shoot
                if (weapons[i].addPiece())
                {
                    Debug.Log("Weapon " + i + " triggered : " + ongoingTime);
                    //Detect enemies that should be destroy and destroy them
                    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

                    for(int j = 0; j < enemies.Length; j++)
                    {
                        EnemyBehaviour e = enemies[i].GetComponent<EnemyBehaviour>();

                        if(e.direction == weapons[i].clearDirection && e.activated)
                        {
                            Destroy(e);
                        }
                    }

                }
            }
            
        }
        
    }
    
}



