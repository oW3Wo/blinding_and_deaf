using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {

        //Debug.Log(1);
        if ((other.tag == "P1A" &&this.tag=="P2A")||(other.tag == "P2A" && this.tag == "P1A"))
        {

            Debug.Log(2);
            if (this.GetComponentInParent<PlayerFollowers>().playerfollowerQuan >= 1)
            {
                Debug.Log(3);
                //this.GetComponentInParent<PlayerFollowers>().playerfollowerQuan--;
                other.GetComponentInParent<PlayerFollowers>().HP--;
                if(this.GetComponentInParent<PlayerFollowers>().
                    GetComponentsInChildren<FollowerProperties>().Length>=1)
                Destroy(this.GetComponentInParent<PlayerFollowers>().
                    GetComponentsInChildren<FollowerProperties>()[0].gameObject);

            }
        }
    }
}
