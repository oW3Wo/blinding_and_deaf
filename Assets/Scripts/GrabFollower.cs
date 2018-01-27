using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabFollower : MonoBehaviour
{
    private Transform player1, player2;
    private bool grab1 = false, grab2 = false, enc = false;

    private Vector3 startMarker, endMarker;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;

    // Use this for initialization
    void Start()
    {
        player1 = FindObjectsOfType<PlayerControl>()[1].transform;
        player2 = FindObjectsOfType<PlayerControl>()[0].transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (grab1)
        {
            Grab1(player1.transform.position);
            player1.GetComponent<PlayerFollowers>().playerfollowerQuan++;
        }

        if (grab2)
        {
            Grab2(player2.transform.position);
            player2.GetComponent<PlayerFollowers>().playerfollowerQuan++;
        }

        if (Input.GetKeyDown(KeyCode.Space) && !grab2)
        {
            if (Vector3.Distance(this.transform.position, player1.transform.position) <= 1)
                grab1 = true;

            Debug.Log("Grab1");
        }


        if (Input.GetKeyDown(KeyCode.M) && !grab1)
        {
            if (Vector3.Distance(this.transform.position, player2.transform.position) <= 1)
                grab2 = true;

            Debug.Log("Grab2");
        }

        if (this.transform.position == endMarker)
        {
            this.GetComponent<GrabFollower>().enabled = false;
        }

    }

    void Grab1(Vector3 end)
    {
        if (!enc)
        {
            this.transform.SetParent(player1);
            startMarker = this.transform.position;
            endMarker = end + new Vector3(Random.Range(0.2f, 0.4f), this.transform.position.y, Random.Range(0.2f, 0.4f));
            startTime = Time.time;
            journeyLength = Vector3.Distance(startMarker, endMarker);
            enc = true;
        }

        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        this.transform.position = Vector3.Lerp(startMarker, endMarker, fracJourney);
    }

    void Grab2(Vector3 end)
    {
        if (!enc)
        {
            this.transform.SetParent(player2);
            startMarker = this.transform.position;
            endMarker = end + new Vector3(Random.Range(0.2f, 0.4f), this.transform.position.y, Random.Range(0.2f, 0.4f));
            journeyLength = Vector3.Distance(startMarker, endMarker);
            startTime = Time.time;
            enc = true;
        }

        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        this.transform.position = Vector3.Lerp(startMarker, endMarker, fracJourney);
    }
}
