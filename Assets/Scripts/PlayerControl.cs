using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float xspeed, zspeed;
    bool xp1, xp2, zp1, zp2;
    // Use this for initialization
    void Start()
    {
        xspeed = 0;
        zspeed = 0;
        zp1 = false;
        xp1 = false;
        zp2 = false;
        xp2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = new Vector3(this.transform.position.x + xspeed * Time.deltaTime,
        //    this.transform.position.y, this.transform.position.z + zspeed * Time.deltaTime);
        this.GetComponent<Rigidbody>().velocity = new Vector3(xspeed, 0, zspeed);
        this.GetComponent<PlayerFollowers>().playerfollowerQuan = this.GetComponentsInChildren<FollowerProperties>().Length;
        if (this.name == "Player1")
        {
            if (Input.GetKey(KeyCode.D) && !xp2)
            {
                xspeed = 3f;
                xp1 = true;
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                xspeed = 0f;
                xp1 = false;
            }
            if (Input.GetKey(KeyCode.A) && !xp1)
            {
                xspeed = -3f;
                xp2 = true;
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                xspeed = 0;
                xp2 = false;
            }
            if (Input.GetKey(KeyCode.W) && !zp2)
            {
                zspeed = 3f;
                zp1 = true;
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                zspeed = 0f;
                zp1 = false;
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                zspeed = 0f;
                zp2 = false;
            }
            if (Input.GetKey(KeyCode.S) && !zp1)
            {
                zspeed = -3f;
                zp2 = true;
            }
        }
        if (this.name == "Player2")
        {
            if (Input.GetKey(KeyCode.RightArrow)&&!xp1)
            {
                xspeed = 3f;
                xp2 = true;
            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                xspeed = 0f;
                xp2 = false;
            }
            if (Input.GetKey(KeyCode.LeftArrow) && !xp2)
            {
                xspeed = -3f;
                xp1 = true;
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                xspeed = 0;
                xp1 = false;
            }
            if (Input.GetKey(KeyCode.UpArrow) && !zp1)
            {
                zspeed = 3f;
                zp2 = true;
            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                zspeed = 0f;
                zp2 = false;
            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                zspeed = 0f;
                zp1 = false;
            }
            if (Input.GetKey(KeyCode.DownArrow) && !zp2)
            {
                zspeed = -3f;
                zp1 = true;
            }
        }
    }
}
