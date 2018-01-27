using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    float xspeed, zspeed;
	// Use this for initialization
	void Start () {
        xspeed = 0;
        zspeed = 0;
	}
	
	// Update is called once per frame
	void Update () {
        
        this.transform.position = new Vector3(this.transform.position.x + xspeed * Time.deltaTime,
            this.transform.position.y, this.transform.position.z + zspeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.D))
        {
            xspeed = 1f;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            xspeed = 0f;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            xspeed = -1f;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            xspeed = 0;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            zspeed = 1f;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            zspeed = 0f;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            zspeed = 0f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            zspeed = -1f;
        }
    }
}
