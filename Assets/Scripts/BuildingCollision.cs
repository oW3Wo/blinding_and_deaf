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
        if (collision.transform.name == "Player1" && p1.GetComponent<PlayerFollowers>().playerfollowerQuan >= 1
            && this.GetComponent<BuildingFollowers>().build == Static.BuildBl.none)
        {
            this.GetComponent<BuildingFollowers>().redfollower++;
            if (this.GetComponent<BuildingFollowers>().greenfollower > 0)
                this.GetComponent<BuildingFollowers>().greenfollower--;
            p1.GetComponent<PlayerFollowers>().playerfollowerQuan--;
            if (p1.GetComponentsInChildren<Transform>()[1].gameObject)
                Destroy(p1.GetComponentsInChildren<Transform>()[1].gameObject);
        }

        if (collision.transform.name == "Player2" && p2.GetComponent<PlayerFollowers>().playerfollowerQuan >= 1
            && this.GetComponent<BuildingFollowers>().build == Static.BuildBl.none)
        {
            this.GetComponent<BuildingFollowers>().greenfollower++;
            if (this.GetComponent<BuildingFollowers>().redfollower > 0)
                this.GetComponent<BuildingFollowers>().redfollower--;
            p2.GetComponent<PlayerFollowers>().playerfollowerQuan--;
            if (p1.GetComponentsInChildren<Transform>()[1].gameObject)
                Destroy(p2.GetComponentsInChildren<Transform>()[1].gameObject);
        }

        if (this.GetComponent<BuildingFollowers>().followerQuan <= this.GetComponent<BuildingFollowers>().redfollower++)

        {
            if (collision.transform.name == "Player1")
            {
                this.GetComponent<BuildingFollowers>().build = Static.BuildBl.player1;
            }
        }
        if (this.GetComponent<BuildingFollowers>().followerQuan <= this.GetComponent<BuildingFollowers>().greenfollower++)
        {
            if (collision.transform.name == "Player2")
            {
                this.GetComponent<BuildingFollowers>().build = Static.BuildBl.player2;
            }
        }

    }
}
