using UnityEngine;
using System.Collections;

public class RaiseBarInBack : MonoBehaviour {

    public ParticleEmitter emmiter;

	// Use this for initialization
	void Start () {
        emmiter = (GameObject)Instantiate( , transform.position, Quaternion.identity);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
