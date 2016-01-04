using UnityEngine;
using System.Collections;

public class blink : MonoBehaviour {

    private GameObject topLid;
    private GameObject bottomLid;

	// Use this for initialization
	void Start () {
        topLid = GameObject.Find("blinkUpper");
        bottomLid = GameObject.Find("blinkLower");

	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            topLid.GetComponent<Animation>().Play("blinkUpper");
            bottomLid.GetComponent<Animation>().Play("blinkLower");

        }
	}
}
