using UnityEngine;
using System.Collections;

public class Add_Basic_Test_sound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Play door creak? not sure");

        if (Input.GetKey(KeyCode.Comma)) {
            GetComponent<AudioSource>().Play();
        }
	
	}
}
