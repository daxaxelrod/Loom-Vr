using UnityEngine;
using System.Collections;

public class FurnatureStorescene : MonoBehaviour {

    private bool hitTrigger = false;

    void OnTriggerEnter() {
        hitTrigger = true;
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (hitTrigger) {
            Application.LoadLevel(4);
        }

	}
}
