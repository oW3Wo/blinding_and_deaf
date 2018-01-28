using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCollision : MonoBehaviour
{
    public GameObject p1, p2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.transform.tag == "Player1" && p1.GetComponent<PlayerFollowers>().playerfollowerQuan >= 1
            && this.GetComponent<BuildingFollowers>().build != Static.BuildBl.player1)
        {
       
                this.GetComponent<BuildingFollowers>().redfollower++;
            if (this.GetComponent<BuildingFollowers>().greenfollower > 0)
            {
                this.GetComponent<BuildingFollowers>().greenfollower--;
                //Debug.Log(1);
            }
            //p1.GetComponent<PlayerFollowers>().playerfollowerQuan--;
            if (p1.GetComponentsInChildren<FollowerProperties>().Length >= 1)
                if (p1.GetComponentsInChildren<FollowerProperties>()[0].gameObject)
                    Destroy(p1.GetComponentsInChildren<FollowerProperties>()[0].gameObject);
        }

        if (collision.transform.tag == "Player2" && p2.GetComponent<PlayerFollowers>().playerfollowerQuan >= 1
            && this.GetComponent<BuildingFollowers>().build != Static.BuildBl.player2)
        {
            this.GetComponent<BuildingFollowers>().greenfollower++;
            if (this.GetComponent<BuildingFollowers>().redfollower > 0)
                this.GetComponent<BuildingFollowers>().redfollower--;
            //p2.GetComponent<PlayerFollowers>().playerfollowerQuan--;
            if (p2.GetComponentsInChildren<FollowerProperties>().Length >= 2)
                if (p2.GetComponentsInChildren<FollowerProperties>()[0].gameObject)
                    Destroy(p2.GetComponentsInChildren<FollowerProperties>()[0].gameObject);
        }

        if (this.GetComponent<BuildingFollowers>().followerQuan <= this.GetComponent<BuildingFollowers>().redfollower)

        {
            if (collision.transform.tag == "Player1")
            {
                this.GetComponent<BuildingFollowers>().build = Static.BuildBl.player1;
            }
        }
        if (this.GetComponent<BuildingFollowers>().followerQuan <= this.GetComponent<BuildingFollowers>().greenfollower)
        {
            if (collision.transform.tag == "Player2")
            {
                this.GetComponent<BuildingFollowers>().build = Static.BuildBl.player2;
            }
        }

    }
}
