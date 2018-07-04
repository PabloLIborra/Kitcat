﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Piece {

    public int length;  //Number of pieces that have to be completed in order to unleash the weapon power
    public int clearDirection;  //Direction that the weapon clears when loaded

    public Piece[] totalPieces;
    public Piece[] pieces;

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
            remaining = length;
            return true;
        }

        return false;
    }
}
