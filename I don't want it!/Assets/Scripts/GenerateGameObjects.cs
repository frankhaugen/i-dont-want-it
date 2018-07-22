using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateGameObjects : MonoBehaviour {

    public GameObject Player1;
    public GameObject Player2;
    public Sprite sprite;

    private void Awake()
    {
        Player1 = new GameObject();
        Player2 = new GameObject();
    }

    // Use this for initialization
    void Start ()
    {
        Player1.name = "Player 1";
        Player1.AddComponent<SpriteRenderer>();
        Player1.GetComponent<SpriteRenderer>().size = new Vector2(5.5f, -2.5f);
        Player1.GetComponent<SpriteRenderer>().color = Color.black;
        Player1.GetComponent<SpriteRenderer>().sprite = sprite;
        Player1.transform.position = new Vector3(0f, -2.5f, 0f);
        Player1.transform.localScale = new Vector3(6f, 5f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
