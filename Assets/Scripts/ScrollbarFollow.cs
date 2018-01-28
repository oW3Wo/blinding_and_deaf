using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarFollow : MonoBehaviour {

    public float xOffset;
    public float yOffset;
    public RectTransform recTransform;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 player2DPosition = Camera.main.WorldToScreenPoint(transform.position);
        recTransform.position = player2DPosition + new Vector2(xOffset, yOffset);

         
        if (player2DPosition.x > Screen.width || player2DPosition.x < 0 || player2DPosition.y > Screen.height || player2DPosition.y < 0)
        {
            recTransform.gameObject.SetActive(false);
        }
        else
        {
            recTransform.gameObject.SetActive(true);
        }

        recTransform.GetComponent<Scrollbar>().size=((float)this.GetComponent<PlayerFollowers>().HP)/30.0f;
        recTransform.GetComponentsInChildren<Image>()[1].color =
           new Color(1 - ((float)this.GetComponent<PlayerFollowers>().HP) / 30.0f,
           ((float)this.GetComponent<PlayerFollowers>().HP) / 30.0f,0);
    }
}
