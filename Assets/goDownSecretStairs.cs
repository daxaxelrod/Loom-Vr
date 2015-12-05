using UnityEngine;
using System.Collections;

public class goDownSecretStairs : MonoBehaviour {

    private bool hitTrigger = false;
    private int stepCount;

    void OnTriggerEnter(Collider player) {
        hitTrigger = true;


    }

    void OnTriggerExit() {
        hitTrigger = false;
    }




	// Use this for initialization
	void Start () {
        stepCount = gameObject.transform.childCount;

	}
	
	// Update is called once per frame
	void Update () {
        if (hitTrigger) {
            for (int i = 0; i < stepCount; i++) {
                // run the incrementing transform in here
                GameObject rig = GameObject.FindGameObjectWithTag("MainCamera");
                rig.transform.Translate(new Vector3(0, -1 * Time.deltaTime, 0));

            }
        }
	
	}
}
