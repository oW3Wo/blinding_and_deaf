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

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.name == "Player1" && p1.GetComponent<PlayerFollowers>().playerfollowerQuan >= 1)
        {
            this.GetComponent<BuildingFollowers>().followerQuan--;
            p1.GetComponent<PlayerFollowers>().playerfollowerQuan--;
            Destroy(p1.GetComponentsInChildren<Transform>()[1].gameObject);
        }

        if (collision.transform.name == "Player2" && p2.GetComponent<PlayerFollowers>().playerfollowerQuan >= 1)
        {
            this.GetComponent<BuildingFollowers>().followerQuan--;
            p2.GetComponent<PlayerFollowers>().playerfollowerQuan--;
            Destroy(p2.GetComponentsInChildren<Transform>()[1].gameObject);
        }

        if (this.GetComponent<BuildingFollowers>().followerQuan <= 0)
        {
            if(collision.transform.name == "Player1")
            {
                this.GetComponent<BuildingFollowers>().build = Static.BuildBl.player1;
            }
            if(collision.transform.name == "Player2")
            {
                this.GetComponent<BuildingFollowers>().build = Static.BuildBl.player2;
            }
        }

    }
}
