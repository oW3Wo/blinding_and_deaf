using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowersSpawn : MonoBehaviour {
    private float coolDown;
    public GameObject prefabs;
    public float xmax,xmin,zmax,zmin;
	// Use this for initialization
	void Start () {
        coolDown = Random.Range(0.0f, 10.0f);
	}
	
	// Update is called once per frame
	void Update () {
        coolDown -= Time.deltaTime;
        if (coolDown <= 0)
        {
            Instantiate(prefabs);
            coolDown = 15.0f;
        }
	}

    void randomPos()
    {
        //this.transform.position=new Vector3(Random.Range(xmin,xmax),0,Random.r)
    }
}
