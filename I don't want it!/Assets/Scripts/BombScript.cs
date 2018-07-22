using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombScript : MonoBehaviour {

    public Canvas PopUpCanvas;
    public Canvas GameCanvas;



    // Update is called once per frame
    void Update ()
    {
        if (transform.position.y < -3f || transform.position.y > 3f)
        {

            PopUpCanvas.sortingOrder = 5;
            GameCanvas.sortingOrder = 0;
        }
	}
}
