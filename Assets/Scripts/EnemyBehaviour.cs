using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {
    public float velocity = 1.0f;
    public int direction = 1;
    public bool activated = false;
    public float time = 0.0f;
    public float activeTime = 5.0f;
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

            if(t.position.x > -2)
            {
                Destroy(gameObject);
            }
        }
        if(direction == 2)
        {
            t.position = new Vector3(t.position.x - velocity * Time.deltaTime, t.position.y, t.position.z);

            if(t.position.x < 3)
            {
                Destroy(gameObject);
            }
        }
	}
}
