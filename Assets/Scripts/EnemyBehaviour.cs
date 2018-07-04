using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {
    public float velocity = 1.0f;
    public int direction = 1;
    Transform t;
    // Use this for initialization
    void Start () {
        t = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        //Move from left to right
		if(direction == 1)
        {
            t.position = new Vector3(t.position.x + velocity * Time.deltaTime, t.position.y, t.position.z);

            if(t.position.x > 0)
            {
                Destroy(gameObject);
            }
        }
	}
}
