using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowersSpawn : MonoBehaviour {
    private float coolDown;
    public GameObject prefabs;
    private float xmax = 4.8f, xmin = -4.8f, zmax = 6.8f, zmin = -7.0f;
    private Static.BuildingPos invaPos;
   // private bool spawn;
	// Use this for initialization
	void Start () {
        //spawn = false;
        coolDown = Random.Range(2f, 15.0f);
        RandomPos();
        
    }
	
	// Update is called once per frame
	void Update () {
        coolDown -= Time.deltaTime;
        //if (!spawn)
        //    RandomPos();
        if (coolDown <= 0)
        {
            Instantiate(prefabs,this.transform.position,new Quaternion());
            coolDown = 15.0f;
            RandomPos();
            //spawn = false;
        }
	}

    void RandomPos()
    {
        this.transform.position = new Vector3(Random.Range(xmin, xmax), 0, Random.Range(zmin, zmax));
        //Debug.Log("xmin"+xmin+ "xmax"+xmax + "zmin"+zmin+ "zmax"+zmax);
    }

    bool ValidPos()
    {
        return true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Wall" || other.tag == "Building")
            //spawn = false;
            RandomPos();
    }
}
