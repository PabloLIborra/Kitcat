using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour {

    public List<string> totalGestures = new List<string>();
    public List<string> gestures = new List<string>();
    public bool completed = false;
    public bool active = false;
    public Weapon weapon;

    public List<GameObject> sprites;

    // Use this for initialization
    void Start () {
        float x = transform.position.x - totalGestures.Count * 0.5f + 0.5f;
        float y = transform.position.y + 1;

        for (int i = 0; i < totalGestures.Count; i++)
        {
            GameObject g = new GameObject();
            g.transform.position = new Vector3(x + i, y, 0f);
            SpriteRenderer r = g.AddComponent<SpriteRenderer>();

            switch (totalGestures[i]) {
                case "a":
                    r.sprite = Resources.Load<Sprite>("Sprites/Symbols/a");
                    break;
                case "v":
                    r.sprite = Resources.Load<Sprite>("Sprites/Symbols/v");
                    break;
                case "circulo":
                    r.sprite = Resources.Load<Sprite>("Sprites/Symbols/circulo");
                    break;
                case "horizontal":
                    r.sprite = Resources.Load<Sprite>("Sprites/Symbols/horizontal");
                    break;
                case "vertical":
                    r.sprite = Resources.Load<Sprite>("Sprites/Symbols/vertical");
                    break;
            }

            sprites.Add(g);
        }
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
            Destroy(sprites[0]);
            sprites.RemoveAt(0);

            for(int i = 0; i < sprites.Count; i++)
            {
                Vector3 t = sprites[i].transform.position;
                sprites[i].transform.position = new Vector3(t.x - 0.5f, t.y, 0.0f);
            }
        }
    }
}
