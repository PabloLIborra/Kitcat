using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour {

    public List<string> totalGestures = new List<string>();
    public List<string> gestures = new List<string>();
    public bool completed = false;
    public bool active = false;

    public Weapon weapon;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(totalGestures.Count == gestures.Count)
        {
            weapon.addPiece();
            completed = true;
            gameObject.SetActive(false);
        }
	}

    public void checkGesture(string name)
    {
        string gestureNameDer = totalGestures[gestures.Count] + "Der";
        string gestureNameIzq = totalGestures[gestures.Count] + "Izq";

        if (gestureNameDer == name || gestureNameIzq == name)
        {
            gestures.Add(name);
        }
    }
}
