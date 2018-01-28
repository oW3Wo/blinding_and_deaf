using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingSlider : MonoBehaviour {

    public Slider slider;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        switch (this.GetComponent<BuildingFollowers>().build)
        {
            case Static.BuildBl.player1:
                slider.GetComponentsInChildren<Image>()[0].color = new Color(0.7f, 0.2f, 0.2f);
                slider.GetComponentsInChildren<Image>()[1].color = new Color(0.2f, 0.7f, 0.2f);
                slider.GetComponentsInChildren<Image>()[2].color = new Color(0.7f, 0.2f, 0.2f);

                slider.GetComponent<Slider>().value = (float)this.GetComponent<BuildingFollowers>().greenfollower / (float)this.GetComponent<BuildingFollowers>().followerQuan;
                break;
            case Static.BuildBl.player2:
                slider.GetComponentsInChildren<Image>()[0].color = new Color(0.2f, 0.7f, 0.2f);
                slider.GetComponentsInChildren<Image>()[1].color = new Color(0.7f, 0.2f, 0.2f);
                slider.GetComponentsInChildren<Image>()[2].color = new Color(0.2f, 0.7f, 0.2f);
                slider.GetComponent<Slider>().value = (float)this.GetComponent<BuildingFollowers>().redfollower / (float)this.GetComponent<BuildingFollowers>().followerQuan;

                break;
           default:
                slider.GetComponentsInChildren<Image>()[0].color = new Color(1.0f, 1.0f, 1.0f);


                if (this.GetComponent<BuildingFollowers>().redfollower > this.GetComponent<BuildingFollowers>().greenfollower)
                {

                    slider.GetComponent<Slider>().value = (float)this.GetComponent<BuildingFollowers>().redfollower / (float)this.GetComponent<BuildingFollowers>().followerQuan;
                    slider.GetComponentsInChildren<Image>()[2].color = new Color(0.7f, 0.2f, 0.2f);
                }
                if (this.GetComponent<BuildingFollowers>().redfollower < this.GetComponent<BuildingFollowers>().greenfollower)
                {
                    slider.GetComponent<Slider>().value = (float)this.GetComponent<BuildingFollowers>().greenfollower / (float)this.GetComponent<BuildingFollowers>().followerQuan;

                    slider.GetComponentsInChildren<Image>()[2].color = new Color(0.2f, 0.7f, 0.2f);
                }
                break;
        }
        //slider.GetComponentsInChildren<Image>()[0].color = new Color();
        //slider.GetComponentsInChildren<Image>()[1].color = new Color();
        //slider.GetComponentsInChildren<Image>()[2].color = new Color();

    }
}
