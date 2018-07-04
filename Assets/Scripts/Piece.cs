using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour {

    public List<string> totalGestures = new List<string>();
    public List<string> gestures = new List<string>();
    public bool completed = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(totalGestures.Count == gestures.Count)
        {
            completed = true;
        }
	}

    public void checkGesture(string name)
    {
        if(totalGestures[gestures.Count] == name)
        {
            gestures.Add(name);
        }
    }
}
