using UnityEngine;
using System.Collections;

public class NetworkPlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        var x = Input.GetAxis("Horizontal") * 0.1f;
        var z = Input.GetAxis("Vertixcal") * 0.1f;
	
	}
}
