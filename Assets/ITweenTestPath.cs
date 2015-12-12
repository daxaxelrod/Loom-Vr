using UnityEngine;
using System.Collections;

public class ITweenTestPath : MonoBehaviour {

	// Use this for initialization
	void Start () {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("TestPath"), "time", 10));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
