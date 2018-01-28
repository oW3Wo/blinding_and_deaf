using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawn : MonoBehaviour {
    public float cooldown=10.0f;
    private GameObject go;
    public GameObject prefabs,p1,p2;
   
    private bool time;
    // Use this for initialization
    void Start () {
        time = false;
	}
	
	// Update is called once per frame
	void Update () {
        switch (GetComponent<BuildingFollowers>().build)
        {
            case Static.BuildBl.player1:
                    cooldown -= Time.deltaTime;
                if (cooldown <= 0)
                {
                    go= Instantiate(prefabs, p1.transform.position + 
                        new Vector3(Random.Range(-0.2f, 0.2f), this.transform.position.y, Random.Range(-0.2f, 0.2f)), 
                        new Quaternion());
                    go.transform.parent = p1.transform;
                    go.GetComponent<FollowerProperties>().belong = Static.Belong.player1;
                    go.GetComponent<GrabFollower>().enabled = false;
                    cooldown = 10;
                }
                break;
            case Static.BuildBl.player2:
                cooldown -= Time.deltaTime;
                if (cooldown <= 0)
                {
                    go = Instantiate(prefabs, p2.transform.position +
                       new Vector3(Random.Range(-0.2f, 0.2f), this.transform.position.y, Random.Range(-0.2f, 0.2f)),
                       new Quaternion());
                    go.transform.parent = p2.transform;
                    go.GetComponent<FollowerProperties>().belong = Static.Belong.player2;
                    go.GetComponent<GrabFollower>().enabled = false;
                    cooldown = 10;
                }
                break;

            default:
                break;
        }


    }
}
