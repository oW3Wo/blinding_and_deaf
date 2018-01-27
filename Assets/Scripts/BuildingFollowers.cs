using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingFollowers : MonoBehaviour {

    public int followerQuan;
    public Static.BuildBl build = Static.BuildBl.none;

    private void Start()
    {
        followerQuan = 1;
    }
}
