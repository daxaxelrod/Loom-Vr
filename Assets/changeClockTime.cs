using UnityEngine;
using System.Collections;
using System;


public class changeClockTime : MonoBehaviour {

    private TextMesh clockTextMesh;
    

	// Use this for initialization
	void Start () {
        clockTextMesh = gameObject.GetComponentInChildren<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
        clockTextMesh.text = System.DateTime.Now.ToShortTimeString();
        
	}
}
