using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingFollowers : MonoBehaviour {

    public int redfollower,greenfollower,followerQuan;
    public Static.BuildBl build = Static.BuildBl.none;

    private void Start()
    {
        followerQuan = 5;
        redfollower = 0;
        greenfollower = 0;
    }
}
