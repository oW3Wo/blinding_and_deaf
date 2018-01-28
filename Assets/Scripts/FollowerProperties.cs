using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerProperties : MonoBehaviour {

    public Material material1,material2;
    public Static.Belong belong;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        switch (belong)
        {
            case Static.Belong.player1:
                this.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(material1);
                break;
            case Static.Belong.player2:

                this.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(material2);
                break;
        }
	}
    
}
