using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public int length;  //Number of pieces that have to be completed in order to unleash the weapon power
    public int clearDirection;  //Direction that the weapon clears when loaded
    
    private int remaining;  //Number of pieces remaining in order to complete the weapon

	// Use this for initialization
	void Start () {
        remaining = length;
	}
    
    //Adds a piece to the weapon and returns true if it is ready to shoot
    public bool addPiece()
    {
        remaining--;

        if(remaining == 0)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

            for (int j = 0; j < enemies.Length; j++)
            {
                EnemyBehaviour e = enemies[j].GetComponent<EnemyBehaviour>();

                if (e != null && e.direction == clearDirection && e.activated)
                {
                    Destroy(enemies[j]);
                }
            }

            remaining = length;
            return true;
        }

        return false;
    }
}
