using UnityEngine;
using System.Collections;

public class goUpStairs : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter(Collision player) {
        gameObject.transform.Translate(new Vector3(0,1,0));

    }
	
    // Update is called once per frame
	void Update () {

	
	}
}
