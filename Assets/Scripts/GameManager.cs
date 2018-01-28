using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private GameObject p1, p2;
    public
	// Use this for initialization
	void Start () {
        p1 = GameObject.FindGameObjectWithTag("Player1");
        p2 = GameObject.FindGameObjectWithTag("Player2");
    }
	
	// Update is called once per frame
	void Update () {
        if (p1.GetComponent<PlayerFollowers>().HP <= 0)
        {

        }
        if (p2.GetComponent<PlayerFollowers>().HP <= 0)
        {

        }
    }
}
