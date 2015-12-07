using UnityEngine;
using System.Collections;

public class tentCityAdditive : MonoBehaviour {
    
    void OnTriggerEnter(Collider player) {
        Application.LoadLevelAdditive(6);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	 void Update () {}
}
