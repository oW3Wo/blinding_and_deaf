using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    private Vector3 screenPos;
	// Use this for initialization
	void Start () {
        screenPos = new Vector3();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            screenPos = Camera.main.WorldToScreenPoint(this.transform.position);
            screenPos = new Vector3(screenPos.x, screenPos.y + 0.1f, screenPos.z);
            this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(screenPos.x,screenPos.y,1.0f));
        }
	}
}
