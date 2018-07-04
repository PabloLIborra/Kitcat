using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {
    public float velocity = 1.0f;
    public int direction = 1;

    public bool activated = false;
    public float time = 0.0f;
    public float activeTime = 5.0f;

    public float scaleFactor = 0.5f;

    Transform t;

    // Use this for initialization
    void Start () {
        t = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(Screen.width);
        Debug.Log(t.position.x);
        if (activated)
        {
            //Move from left to right
            if (direction == 1)
            {
                t.position = new Vector3(t.position.x + velocity * Time.deltaTime, t.position.y, t.position.z);

                if (t.position.x > (Screen.width / 2) - Screen.width*0.1)
                {
                    Destroy(gameObject);
                }
            }
            //Move from right to left
            if (direction == 2)
            {
                t.position = new Vector3(t.position.x - velocity * Time.deltaTime, t.position.y, t.position.z);

                if (t.position.x < 3)
                {
                    Destroy(gameObject);
                }
            }
            //Move from top to bottom
            if(direction == 3)
            {
                t.position = new Vector3(t.position.x, t.position.y - velocity * Time.deltaTime, t.position.z);
                t.localScale = new Vector3(t.localScale.x + scaleFactor * Time.deltaTime, t.localScale.y + scaleFactor * Time.deltaTime, t.localScale.z);

                if(t.position.y < 1)
                {
                    Destroy(gameObject);
                }
            }
        }
        else
        {
            time += Time.deltaTime;
            if(time > activeTime)
            {
                activated = true;
            }
        }
	}
}
